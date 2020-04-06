use CoiffeurAppointmentSystem

insert into cas.person (first_name,last_name,email,password,gender_id,city_id,district_id,birth_day,role_id) values('oguzhan','kýr','ogi@ogi.com','123456','1','34','1','19980430',2)
insert into cas.person (first_name,last_name,email,password,gender_id,city_id,district_id,birth_day,role_id) values('eren','sargýn','ee@ee.com','123456','1','34','6','19980110',1)
insert into cas.person (first_name,last_name,email,password,gender_id,city_id,district_id,birth_day,role_id) values('berke','yazýcý','br@br.com','123456','1','34','10','19981020',3)

insert into cas.workplace values('eren berber','0532','erenberber@bb.com','erenin berberi',2,34,6,'berber adresi','121212')

insert into cas.employee values(1,3,'en iyi berber')

insert into cas.work values(3,1,1,50,'her model yapýlýr',30)

insert into cas.appointment (user_id,wp_id,staff_id,work_id) values(1,1,3,1)

insert into cas.comment values('baya iyiydi parasýnýn hakkýný kabul ediyor',1,1)