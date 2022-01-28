CREATE TABLE dbo.KATEGORIJA
( idKat INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  nazivKat NVARCHAR (25) NOT NULL
);
ALTER TABLE kategorija
ADD UNIQUE (nazivKat);

INSERT INTO KATEGORIJA(nazivKat)
VALUES ('Plišane igračke')	
INSERT INTO KATEGORIJA(nazivKat)
VALUES ('Lutke')
INSERT INTO KATEGORIJA(nazivKat) 
VALUES ('Vozila')
INSERT INTO KATEGORIJA(nazivKat)
VALUES ('Figure')
INSERT INTO KATEGORIJA(nazivKat) 
VALUES ('Slagalice')
INSERT INTO KATEGORIJA(nazivKat)
VALUES ('Društvene igre')

create procedure sp_DodajKategoriju
(@nazivKat nvarchar(25))
	as begin
		insert into kategorija(nazivKat)
		values(@nazivKat)
	end

create procedure sp_IzmeniKategoriju
(@idKat int, @nazivKat nvarchar(25))
as begin
	update kategorija
	set nazivKat=@nazivKat
	where idKat=@idKat
end

CREATE TABLE dbo.BREND
( idB INT NOT NULL IDENTITY(10,10) PRIMARY KEY, 
  nazivB NVARCHAR (25) NOT NULL
);
alter table brend
add unique(nazivB)

create procedure sp_DodajBrend(@nazivB nvarchar(25))
	as begin
		insert into BREND(nazivB)
		values(@nazivB)
	end

create procedure sp_IzmeniBrend(@idB int, @nazivB nvarchar(25))
as begin
	update brend
	set nazivB=@nazivB
	where idB=@idB
end

INSERT INTO BREND
VALUES('Amek')
INSERT INTO BREND
VALUES('Adora')
INSERT INTO BREND
VALUES('Disney')
INSERT INTO BREND
VALUES('Barbie')
INSERT INTO BREND
VALUES('Bratz')
INSERT INTO BREND
VALUES('Burago')
INSERT INTO BREND
VALUES('Best luck')
INSERT INTO BREND
VALUES('Clementoni')


CREATE TABLE dbo.PROIZVOD
( idP INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  nazivP NVARCHAR (25) NOT NULL UNIQUE,
  cenaP FLOAT(1) NOT NULL,
  ukupnaKol INTEGER,
  idKat INT NOT NULL,
  idB INT NOT NULL,
  FOREIGN KEY(idKat) REFERENCES KATEGORIJA(idKat),
  FOREIGN KEY(idB) REFERENCES BREND(idB)
);

alter table proizvod
add constraint ukupnaKol
default 0 for ukupnaKol;


select * from PROIZVOD

alter procedure sp_UnesiProizvod
(@nazivP nvarchar(30), 
@cenaP float, 
@nazivKat nvarchar(25), 
@nazivB nvarchar(25))
	as begin
		insert into PROIZVOD(nazivP, cenaP,idKat, idB)
		values(@nazivP, round(@cenaP,2), (select idKat 
										  from KATEGORIJA 
										  where nazivKat=@nazivKat), 
										  (select idB 
										  from brend 
										  where nazivB=@nazivB))
	end


alter view prikazProizvoda as
	select idP, nazivP, cenaP, ukupnaKol, nazivKat, nazivB
	from proizvod, kategorija, brend
	where kategorija.idKat=proizvod.idKat and brend.idB=proizvod.idB


CREATE TABLE dbo.DOBAVLJAC
(  idD INT NOT NULL IDENTITY(5,5) PRIMARY KEY,
   nazivD NVARCHAR(25) NOT NULL,
   adresaD NVARCHAR(25) NOT NULL,
   telefonD NVARCHAR(10)
);
alter table dobavljac 
add pib int not null;

alter table dobavljac
add unique(pib);

alter procedure sp_UnesiDobavljaca
(@nazivDob nvarchar(25),
 @adresaDob nvarchar(25), 
 @telefonDob nvarchar(10), 
 @pib int)
	as begin
		insert into DOBAVLJAC(nazivD, adresaD, telefonD, pib)
		values (@nazivDob, @adresaDob,@telefonDob, @pib)
	end

alter procedure sp_IzmeniDob
(@idD int,
 @nazivDob nvarchar(25), 
 @adresaDob nvarchar(25), 
 @telefonDob nvarchar(10), 
 @pib int)
	as begin
		update dobavljac
		set nazivD=@nazivDob, adresaD=@adresaDob, telefonD=@telefonDob, pib=@pib
		where idD=@idD
	end

CREATE TABLE dbo.MAGACIN
( idM INT NOT NULL IDENTITY(1,1) PRIMARY KEY,  
  nazivM NVARCHAR (25) NOT NULL,
  mestoM NVARCHAR (25) NOT NULL
);


CREATE TABLE dbo.NABAVKA
(  idN INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   datum DATE,
   idD int not null,
   idM int not null,
   FOREIGN KEY(idD)REFERENCES DOBAVLJAC (idD),
   FOREIGN KEY(idM)REFERENCES MAGACIN (idM)
);

CREATE TABLE dbo.STAVKE_NABAVKE
( idP INT NOT NULL,
  idN INT NOT NULL,
  Nkolicina INT NOT NULL,
  PRIMARY KEY (idP,idN),
  FOREIGN KEY(idP)REFERENCES PROIZVOD (idP),
  FOREIGN KEY(idN)REFERENCES NABAVKA (idN)
);
create view view_Nabavke as
select top 100 percent nabavka.idN, 
		nazivD, nazivM, datum, nazivP, Nkolicina 
from NABAVKA,STAVKE_NABAVKE, 
     DOBAVLJAC,MAGACIN,PROIZVOD
where NABAVKA.idN=STAVKE_NABAVKE.idN 
  and NABAVKA.idD=DOBAVLJAC.idD 
  and NABAVKA.idM=MAGACIN.idM 
  and STAVKE_NABAVKE.idP=PROIZVOD.idP
order by datum desc, idN desc


alter procedure sp_UnosNabavke
(@nazivDob nvarchar(25), 
@nazivMag nvarchar(25), 
@datum date)
	as begin
		insert into NABAVKA(idD, idM, datum)
		values ((select idD from DOBAVLJAC where nazivD=@nazivDob),
				(select idM from MAGACIN where nazivM=@nazivMag), 
				@datum)
	end

alter procedure sp_UnosDobavljeneRobe
(@nazivPro nvarchar(30), 
 @kol int)
	as begin
	begin tran
		insert into STAVKE_NABAVKE(idN,idP,Nkolicina)
		values ((select idN from NABAVKA where idN=IDENT_CURRENT('NABAVKA')), 
				(select idP from proizvod where nazivP=@nazivPro), @kol)

		if @@ROWCOUNT>0
		begin
			commit
			update PROIZVOD
			set ukupnaKol=coalesce(ukupnaKol+@kol,ukupnaKol,@kol,0)
			where nazivP=@nazivPro
		end
	end


alter procedure sp_UkloniStavkuNabavke(@nazivPro nvarchar(25))
	as begin
	begin tran
		declare @kol int
		set @kol= (select Nkolicina 
				   from STAVKE_NABAVKE 
				   where idP=(select idP 
							  from PROIZVOD
							  where nazivP=@nazivPro) 
				   and idN=(select max(idN) from NABAVKA))


		delete
		from STAVKE_NABAVKE
		where idP = (select idP 
					 from PROIZVOD 
					 where nazivP=@nazivPro 
					 and idN=(select max(idN) from NABAVKA))

		
		if @@ROWCOUNT>0
			begin
				commit
				update PROIZVOD
				set ukupnaKol=coalesce(ukupnaKol-@kol,ukupnaKol,@kol,0)
				where nazivP=@nazivPro
			end
	end

select * from STAVKE_NABAVKE order by idN asc

select * from PROIZVOD



--alter trigger trig_UvecajKolicinu on stavke_nabavke after insert as
--	begin
--	declare @ukupnaKolicina int;
--		set @ukupnaKolicina= (select inserted.Nkolicina from inserted)
--		update PROIZVOD set ukupnaKol=coalesce(ukupnaKol+@ukupnaKolicina,ukupnaKol,@ukupnaKolicina,0) where idP=(select inserted.idP from inserted)
--	end;

--disable trigger trig_UvecajKolicinu on stavke_nabavke


delete from STAVKE_NABAVKE
select * from PROIZVOD
select * from STAVKE_NABAVKE
select * from NABAVKA
delete from NABAVKA

select top 1 * 
from STAVKE_NABAVKE 
where idN=(select max(idN) from STAVKE_NABAVKE)
order by idp desc

select * from PROIZVOD

INSERT INTO MAGACIN
VALUES('Magacin 1', 'Novi Beograd')
INSERT INTO MAGACIN
VALUES('Magacin 2', 'Rakovica')

select * from MAGACIN

CREATE TABLE dbo.POSAO
(  idPosla INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   nazivPosla nvarchar(30)
);

INSERT INTO POSAO
VALUES('Rukovodilac')
INSERT INTO POSAO
VALUES('Prodavac')


CREATE TABLE dbo.ZAPOSLENI
( idZ INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  ime NVARCHAR (30) NOT NULL,
  prezime NVARCHAR (30) NOT NULL,
  korIme NVARCHAR (25) NOT NULL,
  lozinka NVARCHAR (25) NOT NULL,
  datZap DATE NOT NULL,
  plata FLOAT NOT NULL,
  adresaZ NVARCHAR (25) NOT NULL,
  emailZ NVARCHAR (25),
  telefonZ NVARCHAR (15),
  idPosla INT NOT NULL,
  FOREIGN KEY(idPosla) REFERENCES POSAO(idPosla)
);

alter table zaposleni
add unique(korIme)

alter table zaposleni
add aktivan bit not null default 1;

select * from ZAPOSLENI

create procedure sp_UnosZaposlenog
(	@ime nvarchar(30), 
	@prezime nvarchar(30), 
	@korIme nvarchar(25), 
	@lozinka nvarchar(25), 
	@datZap date, 
	@plata float, 
	@adresaZ nvarchar(25), 
	@emailZ nvarchar(30),
	@telefonZ nvarchar(15),
	@nazivPosla nvarchar(30)) 
	as begin
		insert into ZAPOSLENI(ime, prezime, 
							  korIme, lozinka, 
							  datZap, plata, 
							  adresaZ, emailZ, telefonZ, idPosla)
		values(@ime, @prezime, 
			   @korIme, @lozinka, 
			   @datZap, @plata, @adresaZ, @emailZ, @telefonZ, 
			   (select idPosla from posao where nazivPosla=@nazivPosla))
	end;

create procedure sp_Otpusti(@idZaposlenog int)
	as begin
		update zaposleni
		set aktivan=0
		where idZ=@idZaposlenog
	end

select * from ZAPOSLENI

CREATE TABLE dbo.RACUN
( idR INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  ukupanIznos FLOAT,
  idZ INT NOT NULL,
  FOREIGN KEY(idZ) REFERENCES ZAPOSLENI(idZ)
);

alter table racun
add datum datetime

alter procedure sp_NapraviRacun(@idZ int)
	as begin
		insert into RACUN(datum, idZ)
		values (SYSDATETIME(), @idZ)
	end

select * from RACUN
delete  from racun

CREATE TABLE dbo.STAVKE_RACUNA
( idR INT NOT NULL,
  idP INT NOT NULL,
  kupljenaKol INT NOT NULL,
  PRIMARY KEY (idR,idP),
  FOREIGN KEY(idR)REFERENCES RACUN (idR),
  FOREIGN KEY(idP)REFERENCES PROIZVOD (idP)
);

alter procedure sp_UnosStavkiRacuna(@nazivPro nvarchar(30), @kol int)
	as begin
	begin tran
		declare @uKol int
		set @ukol = (select ukupnaKol from PROIZVOD where nazivP = @nazivPro)
		
		if @uKol>=@kol
		begin
			insert into STAVKE_RACUNA(idR,idP,kupljenaKol)
			values ((select idR from RACUN where idR=IDENT_CURRENT('RACUN')),
					(select idP from proizvod where nazivP=@nazivPro), @kol)

			declare @cenaP float
			set @cenaP= (select cenaP from PROIZVOD where nazivP=@nazivPro)

			declare @cenaU float
			set @cenaU = @cenaP * cast(@kol as float)

			if @@ROWCOUNT>0
			begin
				commit
				update RACUN
				set ukupanIznos=round(coalesce(ukupanIznos+@cenaU,ukupanIznos,@cenaU,0),2)
				where idR=IDENT_CURRENT('RACUN')

				update PROIZVOD
				set ukupnaKol = ukupnaKol - @kol
				where nazivP=@nazivPro
			end
			else
			begin
				rollback
			end			
		end
		else
			print 'Nema dovoljno proizvoda na stanju'
	end

alter procedure sp_StornirajStavku(@idP int)
	as begin
	begin tran
		
		declare @cenaP float
		set @cenaP= (select cenaP from PROIZVOD where idP=@idP)

		declare @cenaU float
		set @cenaU = @cenaP * cast((select kupljenaKol 
									from STAVKE_RACUNA 
									where idP=@idP and idR=(select max(idR) from RACUN)) as float)

		declare @kol int
		set @kol = (select kupljenaKol 
					from STAVKE_RACUNA 
					where idP=@idP and idR=(select max(idR) from RACUN))


		delete  
		from STAVKE_RACUNA
		where idR=(select max(idR) from STAVKE_RACUNA) and idP=@idP

		if @@ROWCOUNT>0
			begin
				commit
				update RACUN
				set ukupanIznos= ukupanIznos-@cenaU
				where idR=IDENT_CURRENT('RACUN')

				update PROIZVOD
				set ukupnaKol = ukupnaKol + @kol
				where idP=@idP

			end
			else
			begin
				rollback
				end
	end


create table dbo.KUPAC
(
  idKupca INT IDENTITY(1,1) NOT NULL primary key,
  imeKup nvarchar (30) NOT NULL,
  prezimeKup nvarchar(30) NOT NULL,
  adresaKup nvarchar(30) NOT NULL,
  telefonKup nvarchar(15) NOT NULL,
  emailKup nvarchar(30)

);

create procedure sp_DodajKupca
(@ime nvarchar(30), 
 @prezime nvarchar(30), 
 @adresa nvarchar(30), 
 @telefon nvarchar(15), 
 @email nvarchar(30))
	as begin
		insert into KUPAC(imeKup, prezimeKup, adresaKup, telefonKup, emailKup)
		values (@ime, @prezime, @adresa, @telefon, @email)
	end

select * from kupac

create table dbo.RESENJE_REKLAMACIJE
(  idResenja INT IDENTITY(10,10) NOT NULL,
   resenje nvarchar(30)
);

alter table resenje_reklamacije
add primary key(idResenja)


insert into RESENJE_REKLAMACIJE(resenje)
values('Popravka proizvoda')
insert into RESENJE_REKLAMACIJE
values('Zamena proizvoda')
insert into RESENJE_REKLAMACIJE
values('Povraćaj novca')


create table dbo.REKLAMACIJA
(  idReklamacije INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
   idR int not null,
   idKupca int not null,
   idP int not null,
   idResenja int not null,
   datum date not null,
   rok_izvrsenja date not null,
   zavrseno bit not null,
   foreign key(idR) references racun(idR),
   foreign key(idP) references proizvod(idP),
   foreign key(idKupca) references kupac(idKupca),
   foreign key(idResenja) references resenje_reklamacije(idResenja)
);

delete from REKLAMACIJA


create procedure sp_UnesiReklamaciju
(@idR int,
 @idK int, 
 @nazivP nvarchar(30), 
 @resenje nvarchar(30), 
 @datum date, 
 @rok date, 
 @zavrseno bit)
	as begin
		insert into reklamacija (idR, idKupca, idP, 
								 idResenja, datum, rok_izvrsenja, zavrseno)
		values(@idR, @idK, (select idP from PROIZVOD where nazivP=@nazivP), 
			  (select idResenja from RESENJE_REKLAMACIJE where resenje=@resenje), 
			  @datum, @rok, @zavrseno)
	end

select idP, sum(kupljenaKol)
from STAVKE_RACUNA
group by idP


alter view poredjajOdNajprodavanijeg as
	select distinct top 100 percent proizvod.idP, 
			nazivP as 'Naziv proizvoda' , 
			Prodata_kolicina=SUM(kupljenaKol) over (partition by proizvod.idP)
	from stavke_racuna, proizvod
	where stavke_racuna.idP=PROIZVOD.idP
	order by Prodata_kolicina desc


select idP, kupljenaKol
from STAVKE_RACUNA
where idP=2
	
select * from PROIZVOD
select * from racun
select * from STAVKE_NABAVKE order by idN desc

create view view_Zaposleni as
	select * from ZAPOSLENI where aktivan=1

create view view_Otpusteni as
	select * from ZAPOSLENI where aktivan=0


alter procedure sp_prikazRacuna (@idZ int)
as begin
	select racun.idR, datum, ukupanIznos, nazivP, cenaP
	from racun, STAVKE_RACUNA, PROIZVOD
	where racun.idR=STAVKE_RACUNA.idR 
	  and STAVKE_RACUNA.idP=PROIZVOD.idP 
	  and idZ=@idZ
	order by datum desc
end

alter procedure sp_RacuniPoDatumu (@idZ int, @datum date)
as begin
	select racun.idR, datum, ukupanIznos, nazivP, cenaP
	from racun, STAVKE_RACUNA, PROIZVOD
	where racun.idR=STAVKE_RACUNA.idR 
		  and STAVKE_RACUNA.idP=PROIZVOD.idP 
		  and idZ=@idZ and cast(datum as date)=@datum
end

alter procedure sp_IzmeniReklamaciju
(@idReklamacije int, 
 @prihvacena bit, 
 @zavrsena bit)
as begin
	update reklamacija
	set zavrseno=@zavrsena, prihvacena=@prihvacena
	where idReklamacije=@idReklamacije

end


alter view view_ZavrseneReklamacije as
	select idReklamacije, idR as 'Broj racuna', kupac.idKupca, 
		   concat(imeKup,' ', prezimeKup) as 'Ime i prezime kupca', 
		   resenje, datum, rok_izvrsenja, prihvacena
	from reklamacija, RESENJE_REKLAMACIJE, KUPAC
	where REKLAMACIJA.idKupca=KUPAC.idKupca 
	  and reklamacija.idResenja=RESENJE_REKLAMACIJE.idResenja and zavrseno=1


alter view view_NezavrseneReklamacije as
	select idReklamacije, idR as 'Broj racuna', kupac.idKupca, 
		   concat(imeKup,' ', prezimeKup) as 'Ime i prezime kupca', 
		   resenje, datum, rok_izvrsenja, prihvacena
	from reklamacija, RESENJE_REKLAMACIJE, KUPAC
	where REKLAMACIJA.idKupca=KUPAC.idKupca 
	and reklamacija.idResenja=RESENJE_REKLAMACIJE.idResenja and zavrseno=0

create view racun_report as
	select idR as BrRacuna, 
		   datum, concat(ime, ' ', prezime) as 'Prodavac', ukupanIznos
	from racun, ZAPOSLENI
	where racun.idZ=ZAPOSLENI.idZ 
	  and idR = (Select max(idR) from racun )


create view stavkeRacuna_report as
	select nazivP, cenaP, kupljenaKol
	from STAVKE_RACUNA, PROIZVOD
	where STAVKE_RACUNA.idP=PROIZVOD.idP 
		  and idR=(select max(idR) from RACUN)

	select * from REKLAMACIJA

update PROIZVOD
set cenaP=990
where nazivP='Bager'

select * from STAVKE_NABAVKE
order by idN desc

select * from racun


alter procedure sp_IzmeniZap
(	@idZ int,
	@ime nvarchar(30), 
	@prezime nvarchar(30), 
	@korIme nvarchar(25), 
	@lozinka nvarchar(25), 
	@datZap date, 
	@plata float, 
	@adresaZ nvarchar(25), 
	@emailZ nvarchar(30),
	@telefonZ nvarchar(15),
	@nazivPosla nvarchar(30)) 
	as begin
		update zaposleni
		set ime=@ime, prezime=@prezime, 
		korIme=@korIme, lozinka=@lozinka, 
		datZap=@datZap,plata=@plata, 
		adresaZ=@adresaZ, emailZ=@emailZ, telefonZ=@telefonZ, 
		idPosla=(select idPosla from posao where nazivPosla=@nazivPosla)
		where idZ=@idZ
	end
	
create procedure sp_VratiOtpustenog(@idZ int)
	as begin
	update ZAPOSLENI
	set aktivan=1
	where idZ=@idZ
	end
		

create procedure sp_IzmeniProizvod
(@idP int, 
@nazivP nvarchar(25), 
@cenaP float, 
@nazivKat nvarchar(25) ,
@nazivB nvarchar(25))
as begin
	update proizvod
	set nazivP=@nazivP, 
		cenaP=@cenaP, 
		idKat = (select idKat 
				 from kategorija 
				 where nazivKat=@nazivKat), 
		idB = (select idB 
			   from brend 
			   where nazivB=@nazivB)
	where idP=@idP
end

create procedure sp_ProizvodiIzKategorije(@nazivKat nvarchar(25))
as begin
	select * 
	from proizvod 
	where idKat =(select idKat from kategorija where nazivKat=@nazivKat)
end

create procedure sp_ProizvodiIzBrenda(@nazivB nvarchar(25))
as begin
	select * 
	from proizvod 
	where idB =(select idB from brend where nazivB=@nazivB)
end

create procedure sp_ProizvodiKatBrend(@nazivKat nvarchar(25), @nazivB nvarchar(25))
as begin
	select * 
	from PROIZVOD
	where idKat=(select idKat
				 from kategorija
				 where nazivKat=@nazivKat)
	and idB = (select idB
			   from brend
			   where nazivB=@nazivB)
end

create procedure sp_IzmeniKupca
(@idK int,
 @imeK nvarchar(30),
 @prezimeK nvarchar(30),
 @adresa nvarchar(30),
 @telefon nvarchar(15),
 @email nvarchar(30))
 as begin
	update kupac
	set imeKup=@imeK, prezimeKup=@prezimeK, 
		adresaKup=@adresa, telefonKup=@telefon,
		emailKup=@email
	where idKupca=@idK
 end


 select* from reklamacija

alter procedure sp_PrikazReklamacijaZaKupca (@idKupca int)
as begin
	select idReklamacije, nazivP, resenje,datum, rok_izvrsenja, prihvacena, zavrseno
	from kupac, reklamacija, PROIZVOD, RESENJE_REKLAMACIJE
	where KUPAC.idKupca=REKLAMACIJA.idKupca 
	  and PROIZVOD.idP=REKLAMACIJA.idP  
	  and REKLAMACIJA.idResenja=RESENJE_REKLAMACIJE.idResenja 
	  and reklamacija.idKupca=@idKupca
end
