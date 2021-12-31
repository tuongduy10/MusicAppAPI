INSERT INTO Taikhoan VALUES('user','user','Account Test')

INSERT INTO PlayList VALUES(N'List nhạc hay của tui','user')
INSERT INTO PlayList VALUES(N'List nhạc edm cực cháy','user')

INSERT INTO Casi VALUES('Ed Sheeran', 'Ed Sheeran', 'https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/edsheeran.jpeg?alt=media&token=7255aa77-33f3-40d4-a0ec-6d93fe604fbc')
INSERT INTO Casi VALUES('Dua Lipa', 'Dua Lipa', 'https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/dualipa.jpg?alt=media&token=4bb66e9b-ac23-46d5-b36b-59d3ced1d0d2')

INSERT INTO Theloai VALUES(N'Pop')
INSERT INTO Theloai VALUES(N'US/UK')

INSERT INTO Baihat VALUES(N'Shivers','https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/Shivers.mp3?alt=media&token=a2040dcd-1ef9-499a-a222-a72fe057f27a',0,'lyrics','https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/shivers_img.jpg?alt=media&token=580a24dc-8b49-4e8f-99ef-bc6f18397518')
INSERT INTO Baihat VALUES(N'Love Again','https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/Love%20Again.mp3?alt=media&token=8ab02bf7-3f40-4760-8b49-20e0be0970d4',0,'lyrics','https://firebasestorage.googleapis.com/v0/b/gongchaapplication-a6314.appspot.com/o/lovaagain_img.jpg?alt=media&token=b3ac07ff-1fea-4b9f-ba88-4d20677ac8be')

INSERT INTO ChitietBaihat VALUES(1,1)
INSERT INTO ChitietBaihat VALUES(2,2)

INSERT INTO ChitietPlayList VALUES(2,1)
INSERT INTO ChitietPlayList VALUES(2,2)


INSERT INTO ChitietTheloai VALUES(1,1)
INSERT INTO ChitietTheloai VALUES(2,2)


select * from Taikhoan
select * from PlayList
select * from Casi
select * from Theloai
select * from Baihat

select * from ChitietBaihat
select * from ChitietPlayList
select * from ChitietTheloai