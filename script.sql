USE [BookStore]
GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe](
	[MaChuDe] [int] IDENTITY(1,1) NOT NULL,
	[TenChuDe] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChuDe] PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChuDe] ON
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (1, N'Khoc Học ')
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (2, N'Tình yêu')
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (3, N'Giáo Dục')
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (4, N'Ngoại ngữ')
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (5, N'Thiếu Nhi')
INSERT [dbo].[ChuDe] ([MaChuDe], [TenChuDe]) VALUES (6, N'Văn Học Và Cuộc Sống')
SET IDENTITY_INSERT [dbo].[ChuDe] OFF
/****** Object:  Table [dbo].[QuanLy]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuanLy](
	[MaQL] [int] IDENTITY(1,1) NOT NULL,
	[hoTenQL] [nvarchar](50) NULL,
	[taiKhoanQL] [varchar](50) NULL,
	[matKhauQL] [nvarchar](50) NULL,
	[emailQL] [nvarchar](100) NULL,
	[diaChiQL] [nvarchar](200) NULL,
	[dienThoaiQL] [varchar](50) NULL,
	[gioiTinhQL] [nvarchar](3) NULL,
 CONSTRAINT [PK_QuanLy] PRIMARY KEY CLUSTERED 
(
	[MaQL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[QuanLy] ON
INSERT [dbo].[QuanLy] ([MaQL], [hoTenQL], [taiKhoanQL], [matKhauQL], [emailQL], [diaChiQL], [dienThoaiQL], [gioiTinhQL]) VALUES (1, N'Nguyễn Hoài Nam', N'admin', N'123', N'nam@gmail.com', N'90 Đường 4', N'0345284017', N'Nam')
SET IDENTITY_INSERT [dbo].[QuanLy] OFF
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[Diachi] [nvarchar](200) NULL,
	[DienThoai] [varchar](50) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [Diachi], [DienThoai]) VALUES (1, N'Nhà xuất bản Kim Đồng', N'250 Cống Quỳnh', N'028 3925 0177')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [Diachi], [DienThoai]) VALUES (2, N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh', N'62 Nguyễn Thị Minh Khai', N'028 3822 5340')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [Diachi], [DienThoai]) VALUES (3, N'Nhà xuất bản thông tin và truyền thông', N'115, Đ. Trần Duy Hưng', N'024 3577 2138')
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
/****** Object:  Table [dbo].[KhachHang]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[hoTenKH] [nvarchar](50) NULL,
	[taiKhoan] [varchar](50) NULL,
	[matKhauKH] [nvarchar](50) NULL,
	[emailKH] [nvarchar](100) NULL,
	[diaChiKH] [nvarchar](200) NULL,
	[dienThoaiKH] [varchar](50) NULL,
	[gioiTinhKH] [nvarchar](3) NULL,
	[ngaySinhKH] [datetime] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (1, N'Đoàn Hoài Nam', N'nam123', N'123456', N'nam.dh44995@gmail.com', N'90 Nguyễn Oanh', N'0345678956', N'Nam', CAST(0x00008F5900000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (2, N'Nguyễn Vĩnh Bình', N'binh123', N'221212', N'binh123@gmail.com', N'22 Lê Trọng Tấn', N'0347849562', N'Nam', CAST(0x00008F6D00000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (3, N'Nguyễn Thị Doan', N'doan123', N'556677', N'doan@gmail.com', N'22 Trần Hưng Đạo', N'0908804120', N'Nữ', CAST(0x00008F3200000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (4, N'Đặng Hồng Hà', N'ha345', N'1234567', N'ha@gmail.com', N'155 Hiệp Bình', N'0905620450', N'Nữ', CAST(0x00008F1700000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (5, N'Phạm Xuân Dương ', N'duong55', N'456789', N'duong@gmail.com', N'45 QL1', N'0348485742', N'Nam', CAST(0x0000901600000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [hoTenKH], [taiKhoan], [matKhauKH], [emailKH], [diaChiKH], [dienThoaiKH], [gioiTinhKH], [ngaySinhKH]) VALUES (6, N'Lê Minh Long', N'long76', N'147852', N'long@gmail.com', N'29 Thành Vĩnh', N'0378965148', N'Nam', CAST(0x00008F7900000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
/****** Object:  Table [dbo].[TacGia]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [int] IDENTITY(1,1) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[TieuSu] [nvarchar](max) NULL,
	[DienThoai] [varchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [DiaChi], [TieuSu], [DienThoai]) VALUES (1, N'Nguyễn Nhật Ánh', N'55Cao Thắng', N'à tên và cũng là bút danh của một nhà văn Việt Nam chuyên viết cho tuổi mới lớn. Ông sinh ngày 7 tháng 5 năm 1955 tại huyện Thăng Bình, Quảng Nam.', N'0365748254')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [DiaChi], [TieuSu], [DienThoai]) VALUES (2, N'Thích Nhất Hạnh', N'45 Lê Tấn', N'Thích Nhất Hạnh là một thiền sư, giảng viên, nhà văn, nhà thơ, nhà khảo cứu, nhà hoạt động xã hội, và người vận động cho hòa bình. Ông sinh ra ở Thừa Thiên Huế vào ngày 11/10/1926 xuất gia theo Thiền Tông năm 16 tuổi, trở thành một nhà sư vào năm 1949.', N'0347874968')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [DiaChi], [TieuSu], [DienThoai]) VALUES (3, N'Adam Khoo', N'WashingTon', N'Diễn giả Adam Khoo tên đầy đủ là Adam Khoo Yean Ann (sinh ngày 8/4/1974) là một doanh nhân thành đạt, là tác giả của những quyển sách bán chạy nhất và cũng là chuyên gia đào tạo hàng đầu.', N'0356741852')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [DiaChi], [TieuSu], [DienThoai]) VALUES (4, N'Fujiko.F.Fujio', N'Japan', N'Fujiko Fujio (Tiếng Nhật: 藤子 不二雄 ) là bút danh chung của hai nghệ sỹ manga Nhật Bản.', N'0365748987')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
/****** Object:  Table [dbo].[Sach]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[MoTa] [nvarchar](max) NULL,
	[AnhBia] [nvarchar](50) NULL,
	[NgayCapNhat] [datetime] NULL,
	[SoLuongTon] [int] NULL,
	[MaNXB] [int] NULL,
	[MaChuDe] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sach] ON
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (4, N'Còn Chút Gì Để Nhớ', CAST(94000 AS Decimal(18, 0)), N'Đó là những kỷ niệm thời đi học của Chương, lúc mới bước chân vào Sài Gòn và làm quen với cuộc sống đô thị. Là những mối quan hệ bạn bè tưởng chừng hời hợt thoảng qua nhưng gắn bó suốt cuộc đời. Cuộc sống đầy biến động đã xô dạt', N'01', CAST(0x0000AD8A009450C0 AS DateTime), 4, 3, 6)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (5, N'Thằng Quỷ Nhỏ', CAST(94000 AS Decimal(18, 0)), N'Truyện dài đặc sắc nhất của Nguyễn Nhật Ánh. Tập truyện được sinh viên học sinh rất đỗi say mê. Bởi sự dí dỏm, bởi tình người, bởi những hình ảnh rất học sinh, rất áo trắng. Hãy làm quen với Thằng quỷ nhỏ vẩy tai lừa có cái tên con gái ...', N'02', CAST(0x0000AA4D00735B40 AS DateTime), 6, 2, 6)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (6, N'Doraemon', CAST(125000 AS Decimal(18, 0)), N'đây là bộ tuyển tập gồm những chuyến phiêu lưu của Doraemon, Nobita và các bạn đến những vùng đất mới, vốn đã rất quen thuộc với độc giả nhiều thế hệ ', N'03', CAST(0x0000AD8400A4CB80 AS DateTime), 4, 1, 5)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (7, N'Doraemon Học Tập - Sinh Vật Học', CAST(64000 AS Decimal(18, 0)), N'rẻ con luôn có nhiều thắc mắc về các sự vật xung quanh mình. Tập sách giới thiệu tới các bé một số kiến thức cơ bản về sinh vật học thông qua các câu chuyện của các bạn nhỏ đáng yêu.', N'04', CAST(0x0000AD2B0083D600 AS DateTime), 2, 1, 5)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (12, N'Mùa Hạ Đi qua', CAST(100000 AS Decimal(18, 0)), N'Cuốn sách của mùa hạ Tôi bắt đầu mùa hè của mình bằng việc đắm chìm trong cuốn sách kể về cuộc sống nơi hòn đảo nhỏ ở vịnh Phần Lan. Qua từng trang sách, hình ảnh về vùng biển Bắc Âu và những con người nơi đó hiện lên rõ như thể chúng ta đang sống ngay bên cạnh họ vậy.', N'07', CAST(0x0000AD8A009450C0 AS DateTime), 8, 1, 6)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (13, N'Nguồn gốc các loài', CAST(200000 AS Decimal(18, 0)), N'Nguồn gốc các loài của Charles Darwin có thể được coi là một trong các ấn phẩm khoa học tiêu biểu và là tác phẩm nòng cốt của ngành sinh học tiến hóa. Tên đầy đủ của cuốn sách là Về nguồn gốc các loài thông qua chọn lọc tự nhiên, hay việc gìn giữ các chủng ưu thế thông qua cuộc đấu tranh sinh tồn.', N'08', CAST(0x0000AD8A009450C0 AS DateTime), 5, 1, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (14, N'Những nhà khám phá', CAST(15000 AS Decimal(18, 0)), N'The Discoverers là một tác phẩm lịch sử phi hư cấu của Daniel Boorstin, xuất bản năm 1983, và là tác phẩm đầu tiên trong Bộ ba kiến ​​thức, bao gồm The Creators và The Seekers. Cuốn sách có phụ đề Lịch sử tìm kiếm của con người để biết thế giới và chính mình, là một lịch sử khám phá của con người.', N'09', CAST(0x0000AA4D00735B40 AS DateTime), 3, 1, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (15, N'Giáo Dục STEM trong nhà trường phổ thông', CAST(80000 AS Decimal(18, 0)), N'Giáo dục khoa học, công nghệ, kĩ thuật và toán (STEM) đang được nhiều nước có nền khoa học công nghệ tiên tiến trên thế giới triển khai sâu, rộng trong chương trình giáo dục phổ thông. Hình thức giáo dục này đóng vai trò là đòn bẩy để thực hiện mục tiêu giáo dục năng lực cho các công dân tương lai đáp ứng nhu cầu của nền khoa học, công nghệ 4.0 trong thế kỉ XXI', N'02', CAST(0x0000AD8400A4CB80 AS DateTime), 3, 2, 3)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [GiaBan], [MoTa], [AnhBia], [NgayCapNhat], [SoLuongTon], [MaNXB], [MaChuDe]) VALUES (16, N'Giáo Dục - Tương Lai & Đổi Mới', CAST(120000 AS Decimal(18, 0)), N'Từ học giả Eisenhower đến cơn gió giáo dục tươi mới', N'04', CAST(0x0000AD2B0083D600 AS DateTime), 2, 2, 3)
SET IDENTITY_INSERT [dbo].[Sach] OFF
/****** Object:  Table [dbo].[DonHang]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[DaThanhToan] [int] NULL,
	[TinhTrangGiaoHang] [int] NULL,
	[NgayDat] [datetime] NULL,
	[NgayGiao] [datetime] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DonHang] ON
INSERT [dbo].[DonHang] ([MaDonHang], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [MaKH]) VALUES (1, 0, 0, CAST(0x0000AE9B00000000 AS DateTime), CAST(0x0000AEA000000000 AS DateTime), 2)
INSERT [dbo].[DonHang] ([MaDonHang], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [MaKH]) VALUES (2, 1, 1, CAST(0x0000AE7700000000 AS DateTime), CAST(0x0000AE7B00000000 AS DateTime), 1)
INSERT [dbo].[DonHang] ([MaDonHang], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [MaKH]) VALUES (3, 0, 0, CAST(0x0000AE9600000000 AS DateTime), CAST(0x0000AE9B00000000 AS DateTime), 3)
INSERT [dbo].[DonHang] ([MaDonHang], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [MaKH]) VALUES (4, 0, 0, CAST(0x0000AEA800000000 AS DateTime), CAST(0x0000AEAE00000000 AS DateTime), 5)
INSERT [dbo].[DonHang] ([MaDonHang], [DaThanhToan], [TinhTrangGiaoHang], [NgayDat], [NgayGiao], [MaKH]) VALUES (5, 1, 1, CAST(0x0000AE9F00000000 AS DateTime), CAST(0x0000AEA200000000 AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
/****** Object:  Table [dbo].[ThamGia]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGia](
	[MaSach] [int] NOT NULL,
	[MaTacGia] [int] NOT NULL,
	[VaiTro] [nvarchar](50) NULL,
	[ViTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThamGia] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaTacGia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThamGia] ([MaSach], [MaTacGia], [VaiTro], [ViTri]) VALUES (4, 1, N'Viết Sách', N'Nhà Văn')
INSERT [dbo].[ThamGia] ([MaSach], [MaTacGia], [VaiTro], [ViTri]) VALUES (5, 1, N'Viết Sách', N'Nhà Văn')
INSERT [dbo].[ThamGia] ([MaSach], [MaTacGia], [VaiTro], [ViTri]) VALUES (6, 4, N'Viết truyện', N'Biên tập')
INSERT [dbo].[ThamGia] ([MaSach], [MaTacGia], [VaiTro], [ViTri]) VALUES (7, 4, N'Viết truyện', NULL)
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 07/03/2022 21:01:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaDonHang] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSach], [SoLuong], [DonGia]) VALUES (1, 4, 1, CAST(94000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSach], [SoLuong], [DonGia]) VALUES (2, 5, 1, CAST(94000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSach], [SoLuong], [DonGia]) VALUES (3, 6, 1, CAST(125000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSach], [SoLuong], [DonGia]) VALUES (4, 7, 1, CAST(64000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietDonHang] ([MaDonHang], [MaSach], [SoLuong], [DonGia]) VALUES (5, 4, 1, CAST(94000 AS Decimal(18, 0)))
/****** Object:  ForeignKey [FK_ChiTietDonHang_DonHang]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
/****** Object:  ForeignKey [FK_ChiTietDonHang_Sach]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_Sach]
GO
/****** Object:  ForeignKey [FK_DonHang_KhachHang]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_Sach_ChuDe]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_ChuDe] FOREIGN KEY([MaChuDe])
REFERENCES [dbo].[ChuDe] ([MaChuDe])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_ChuDe]
GO
/****** Object:  ForeignKey [FK_Sach_NhaXuatBan]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
/****** Object:  ForeignKey [FK_ThamGia_Sach]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[ThamGia]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ThamGia] CHECK CONSTRAINT [FK_ThamGia_Sach]
GO
/****** Object:  ForeignKey [FK_ThamGia_TacGia]    Script Date: 07/03/2022 21:01:04 ******/
ALTER TABLE [dbo].[ThamGia]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[ThamGia] CHECK CONSTRAINT [FK_ThamGia_TacGia]
GO
