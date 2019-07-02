using System;
using bitproje.Entitys;
using bitproje.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace bitproje.Data
{
    public partial class isgContext : DbContext
    {
        public isgContext()
        {
        }

        public isgContext(DbContextOptions<isgContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Birim> Birim { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Firmagruplari> Firmagruplari { get; set; }
        public virtual DbSet<Egitimler> Egitimler { get; set; }
        public virtual DbSet<Katilimcilar> Katilimcilar { get; set; }
        public virtual DbSet<Ilactanimi> Ilactanimi { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciFirma> KullaniciFirma { get; set; }
        public virtual DbSet<Muayene> Muayene { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Recete> Recete { get; set; }
        public virtual DbSet<Receteilac> Receteilac { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<Tanilar> Tanilar { get; set; }
        public virtual DbSet<Tanitanimi> Tanitanimi { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<YetkiKontrol> Yetki { get; set; }

        // Unable to generate entity type for table 'dbo.kullanicifirma'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                baglantiSinifi bs = new baglantiSinifi();
                optionsBuilder.UseSqlServer(bs.baglan);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birim>(entity =>
            {
                entity.ToTable("birim");

                entity.Property(e => e.Birimid).HasColumnName("birimid");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Birimad)
                    .HasColumnName("birimad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firmaid).HasColumnName("firmaid");

                entity.Property(e => e.Sicilnop).HasColumnName("sicilnop");

                entity.Property(e => e.Tehlikesinif)
                    .HasColumnName("tehlikesinif")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.Birim)
                    .HasForeignKey(d => d.Firmaid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("firmabirimi");

                entity.HasOne(d => d.SicilnopNavigation)
                    .WithMany(p => p.Birim)
                    .HasForeignKey(d => d.Sicilnop)
                    .HasConstraintName("birimper");
            }); 


            modelBuilder.Entity<Firma>(entity =>
            {
                entity.ToTable("firma");

                entity.Property(e => e.Firmaid).HasColumnName("firmaid");

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasMaxLength(500)
                    .IsUnicode(false);


                entity.Property(e => e.Faaliyetalan)
                    .HasColumnName("faaliyetalan")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Durum)
                 .HasColumnName("durum")
                 .HasMaxLength(100)
                 .IsUnicode(false);

                entity.Property(e => e.Faks)
                    .HasColumnName("faks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firmamail)
                    .HasColumnName("firmamail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firmatlfn)
                    .HasColumnName("firmatlfn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Funvan)
                    .HasColumnName("funvan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupId).HasColumnName("grup_id");

                entity.Property(e => e.Grupsirket)
                    .HasColumnName("grupsirket")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Il)
                    .HasColumnName("il")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ilce)
                    .HasColumnName("ilce")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isvrnadsoyad)
                    .HasColumnName("isvrnadsoyad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isvrngsm)
                    .HasColumnName("isvrngsm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sgksicil)
                    .HasColumnName("sgksicil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tehlikesinif)
                    .HasColumnName("tehlikesinif")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grup)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.GrupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("grupid");
            });

            modelBuilder.Entity<Firmagruplari>(entity =>
            {
                entity.HasKey(e => e.GrupId);

                entity.ToTable("firmagruplari");

                entity.Property(e => e.GrupId).HasColumnName("grup_id");

                entity.Property(e => e.GrupAd)
                    .HasColumnName("grup_ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ilactanimi>(entity =>
            {
                entity.HasKey(e => e.Ilacid);

                entity.ToTable("ilactanimi");

                entity.Property(e => e.Ilacid).HasColumnName("ilacid");

                entity.Property(e => e.Ilacadi)
                    .HasColumnName("ilacadi")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.HasKey(e => e.Sicilno);

                entity.ToTable("kullanici");

                entity.Property(e => e.Sicilno)
                    .HasColumnName("sicilno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Cinsiyet)
                    .HasColumnName("cinsiyet")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dogumtarih)
                    .HasColumnName("dogumtarih")
                    .HasColumnType("date");

                entity.Property(e => e.Dogumyer)
                    .HasColumnName("dogumyer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Durum)
                    .HasColumnName("durum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gorevtanim)
                    .HasColumnName("gorevtanim")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isebaslangictarih)
                    .HasColumnName("isebaslangictarih")
                    .HasColumnType("date");

                entity.Property(e => e.Isgkurulgorev)
                    .HasColumnName("isgkurulgorev")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kangrup)
                    .HasColumnName("kangrup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kilo).HasColumnName("kilo");

                entity.Property(e => e.Ogrenimdurum)
                    .HasColumnName("ogrenimdurum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasColumnName("soyad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statü)
                    .HasColumnName("statü")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tc)
                    .HasColumnName("tc")
                    .HasMaxLength(11)
                    .IsUnicode(false);
                entity.Property(e => e.Grupid).HasColumnName("grupid");

                entity.Property(e => e.Unvan)
                    .HasColumnName("unvan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grup)
                    .WithMany(p => p.Kullanici)
                    .HasForeignKey(d => d.Grupid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("idg");
            });

            modelBuilder.Entity<KullaniciFirma>(entity =>
            {
                entity.ToTable("kullanicifirma");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firmaid).HasColumnName("firmaid");

                entity.Property(e => e.Sicilno).HasColumnName("sicilno");

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.KullaniciFirma)
                    .HasForeignKey(d => d.Firmaid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fir");
            });

            modelBuilder.Entity<Muayene>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.ToTable("muayene");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Annehastalikg)
                    .HasColumnName("annehastalikg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Babahastalikg)
                    .HasColumnName("babahastalikg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Büyüktan).HasColumnName("büyüktan");

                entity.Property(e => e.Cocukhastalikg)
                    .HasColumnName("cocukhastalikg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Kangrup)
                    .HasColumnName("kangrup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kardeshastalikg)
                    .HasColumnName("kardeshastalikg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Kilo).HasColumnName("kilo");

                entity.Property(e => e.Kücüktan).HasColumnName("kücüktan");

                entity.Property(e => e.Mneden)
                    .HasColumnName("mneden")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mtarihi)
                    .HasColumnName("mtarihi")
                    .HasColumnType("date");

                entity.Property(e => e.Nabiz).HasColumnName("nabiz");

                entity.Property(e => e.Sicilno).HasColumnName("sicilno");

                entity.Property(e => e.Sicilnop).HasColumnName("sicilnop");

                entity.Property(e => e.Sonrakimtarih)
                    .HasColumnName("sonrakimtarih")
                    .HasColumnType("date");

                entity.HasOne(d => d.SicilnoNavigation)
                    .WithMany(p => p.Muayene)
                    .HasForeignKey(d => d.Sicilno)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("kul2");

                entity.HasOne(d => d.SicilnopNavigation)
                    .WithMany(p => p.Muayene)
                    .HasForeignKey(d => d.Sicilnop)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("per2");
            });

            modelBuilder.Entity<Egitimler>(entity =>
            {
                entity.HasKey(e => e.Egitimid);

                entity.ToTable("egitimler");

                entity.Property(e => e.Egitimid).HasColumnName("egitimid");
                entity.Property(e => e.Sicilno).HasColumnName("sicilno");

                entity.Property(e => e.Egitimtrh)
                   .HasColumnName("egitimtrh")
                   .HasColumnType("date");

                entity.Property(e => e.Egitimalani)
                    .HasColumnName("egitimalani")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Toplamsure).HasColumnName("toplamsure");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasMaxLength(500)
                    .IsUnicode(false);               

                entity.Property(e => e.Egitimkonulari)
                    .HasColumnName("egitimkonulari")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.kullanici)
                    .WithMany(p => p.Egitim)
                    .HasForeignKey(d => d.Sicilno)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("egitim");
            });
            modelBuilder.Entity<Katilimcilar>(entity =>
            {
                entity.HasKey(e => e.Katilimid);

                entity.ToTable("katilimcilar");

                entity.Property(e => e.Katilimid).HasColumnName("katilimid");
                entity.Property(e => e.Egitimid).HasColumnName("egitimid");
                entity.Property(e => e.Sicilnop).HasColumnName("sicilnop");

                entity.Property(e => e.Basariyuzdesi)
                    .HasColumnName("basariyuzdesi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.egitim)
                    .WithMany(p => p.Katilim)
                    .HasForeignKey(d => d.Egitimid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("kat2");

                entity.HasOne(d => d.personel)
                  .WithMany(p => p.Katilim)
                  .HasForeignKey(d => d.Sicilnop)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasConstraintName("kat");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasKey(e => e.Sicilnop);

                entity.ToTable("personel");

                entity.Property(e => e.Sicilnop)
                    .HasColumnName("sicilnop")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Boy).HasColumnName("boy");

                entity.Property(e => e.Cinsiyet)
                    .HasColumnName("cinsiyet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dogumtarih)
                    .HasColumnName("dogumtarih")
                    .HasColumnType("date");

                entity.Property(e => e.Dogumyer)
                    .HasColumnName("dogumyer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firmaid).HasColumnName("firmaid");

                entity.Property(e => e.Isegiristrh)
                    .HasColumnName("isegiristrh")
                    .HasColumnType("date");

                entity.Property(e => e.Kilo).HasColumnName("kilo");

                entity.Property(e => e.Ogrenimdurum)
                    .HasColumnName("ogrenimdurum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasColumnName("soyad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unvan)
                    .HasColumnName("unvan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.Personel)
                    .HasForeignKey(d => d.Firmaid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("perfir");
            });

            modelBuilder.Entity<Recete>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("recete");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Provizyontipi)
                    .HasColumnName("provizyontipi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ralttipi)
                    .HasColumnName("ralttipi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rtarihi)
                    .HasColumnName("rtarihi")
                    .HasColumnType("date");

                entity.Property(e => e.Rtipi)
                    .HasColumnName("rtipi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Serino)
                    .HasColumnName("serino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.M)
                    .WithMany(p => p.Recete)
                    .HasForeignKey(d => d.Mid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("muayene4");
            });

            modelBuilder.Entity<Receteilac>(entity =>
            {
                entity.HasKey(e => e.Rilacid);

                entity.ToTable("receteilac");

                entity.Property(e => e.Rilacid).HasColumnName("rilacid");

                entity.Property(e => e.Ilacdozu)
                    .HasColumnName("ilacdozu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ilacid).HasColumnName("ilacid");

                entity.Property(e => e.Kullanimadedi).HasColumnName("kullanimadedi");

                entity.Property(e => e.Kullanimsekli)
                    .HasColumnName("kullanimsekli")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Periyod)
                    .HasColumnName("periyod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.HasOne(d => d.Ilac)
                    .WithMany(p => p.Receteilac)
                    .HasForeignKey(d => d.Ilacid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ilc");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.Receteilac)
                    .HasForeignKey(d => d.Rid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("rct");
            });

            modelBuilder.Entity<Statu>(entity =>
            {
                entity.ToTable("statu");

                entity.Property(e => e.Statuid).HasColumnName("statuid");

                entity.Property(e => e.Statuadi)
                    .HasColumnName("statuadi")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tanilar>(entity =>
            {
                entity.HasKey(e => e.Taniid);

                entity.ToTable("tanilar");

                entity.Property(e => e.Taniid).HasColumnName("taniid");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Tanimid).HasColumnName("tanimid");

                entity.HasOne(d => d.M)
                    .WithMany(p => p.Tanilar)
                    .HasForeignKey(d => d.Mid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("muayene3");

                entity.HasOne(d => d.Tanim)
                    .WithMany(p => p.Tanilar)
                    .HasForeignKey(d => d.Tanimid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tanit");
            });

            modelBuilder.Entity<Tanitanimi>(entity =>
            {
                entity.HasKey(e => e.Tanitid);

                entity.ToTable("tanitanimi");

                entity.Property(e => e.Tanitid).HasColumnName("tanitid");

                entity.Property(e => e.Taniadi)
                    .HasColumnName("taniadi")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unvan>(entity =>
            {
                entity.ToTable("unvan");

                entity.Property(e => e.Unvanid).HasColumnName("unvanid");

                entity.Property(e => e.Unvanadi)
                    .HasColumnName("unvanadi")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kullaniciadi)
                    .HasColumnName("kullaniciadi")
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.Sifre)
                   .HasColumnName("sifre")
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.Grubu)
              .HasColumnName("grubu")
              .HasMaxLength(50)
              .IsUnicode(false);

                entity.Property(e => e.renk)
            .HasColumnName("renk")
            .HasMaxLength(50)
            .IsUnicode(false);

                entity.Property(e => e.soru)
             .HasColumnName("soru")
             .HasMaxLength(50)
             .IsUnicode(false);

                entity.Property(e => e.cevap)
             .HasColumnName("cevap")
             .HasMaxLength(50)
             .IsUnicode(false);

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Firmaid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fid");

                entity.HasOne(d => d.sicil)
                  .WithMany(p => p.Users)
                  .HasForeignKey(d => d.Sicilno)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasConstraintName("ksicil");


            });

               modelBuilder.Entity<YetkiKontrol>(entity =>
            {
                entity.ToTable("yetkikontrol");
                entity.Property(e => e.Id).HasColumnName("id");
                //firma yetkisi
                entity.Property(e => e.firmafirmaekle).HasColumnName("firmafirmaekle");
                entity.Property(e => e.firmafirmasil).HasColumnName("firmafirmasil");
                entity.Property(e => e.firmafirmaguncel).HasColumnName("firmafirmaguncel");

                entity.Property(e => e.firmabirimekle).HasColumnName("firmabirimekle");
                entity.Property(e => e.firmabirimsil).HasColumnName("firmabirimsil");
                entity.Property(e => e.firmabirimguncel).HasColumnName("firmabirimguncel");

                entity.Property(e => e.firmapersonelekle).HasColumnName("firmapersonelekle");
                entity.Property(e => e.firmapersonelsil).HasColumnName("firmapersonelsil");
                entity.Property(e => e.firmapersonelguncel).HasColumnName("firmapersonelguncel");
          

                entity.Property(e => e.firmailacekle).HasColumnName("firmailacekle");
                entity.Property(e => e.firmailaccsil).HasColumnName("firmailacsil");

                entity.Property(e => e.firmataniekle).HasColumnName("firmataniekle");
                entity.Property(e => e.firmatanisil).HasColumnName("firmatanisil");

                entity.Property(e => e.firmastatuekle).HasColumnName("firmastatuekle");
                entity.Property(e => e.firmastatusil).HasColumnName("firmastatusil");

                //hekim yetkisi
                entity.Property(e => e.hekimfirmaekle).HasColumnName("hekimfirmaekle");
                entity.Property(e => e.hekimfirmasil).HasColumnName("hekimfirmasil");
                entity.Property(e => e.hekimfirmaguncel).HasColumnName("hekimfirmaguncel");

                entity.Property(e => e.hekimbirimekle).HasColumnName("hekimbirimekle");
                entity.Property(e => e.hekimbirimsil).HasColumnName("hekimbirimsil");
                entity.Property(e => e.hekimbirimguncel).HasColumnName("hekimbirimguncel");

                entity.Property(e => e.hekimpersonelekle).HasColumnName("hekimpersonelekle");
                entity.Property(e => e.hekimpersonelsil).HasColumnName("hekimpersonelsil");
                entity.Property(e => e.hekimpersonelguncel).HasColumnName("hekimpersonelguncel");
            

                entity.Property(e => e.hekimilacekle).HasColumnName("hekimilacekle");
                entity.Property(e => e.hekimilacsil).HasColumnName("hekimilacsil");

                entity.Property(e => e.hekimtaniekle).HasColumnName("hekimtaniekle");
                entity.Property(e => e.hekimtanisil).HasColumnName("hekimtanisil");

                entity.Property(e => e.hekimstatuekle).HasColumnName("hekimstatuekle");
                entity.Property(e => e.hekimstatusil).HasColumnName("hekimstatusil");


                //  uzman yetkisi
                entity.Property(e => e.uzmanfirmaekle).HasColumnName("uzmanfirmaekle");
                entity.Property(e => e.uzmanfirmasil).HasColumnName("uzmanfirmasil");
                entity.Property(e => e.uzmanfirmaguncel).HasColumnName("uzmanfirmaguncel");

                entity.Property(e => e.uzmanbirimekle).HasColumnName("uzmanbirimekle");
                entity.Property(e => e.uzmanbirimsil).HasColumnName("uzmanbirimsil");
                entity.Property(e => e.uzmanbirimguncel).HasColumnName("uzmanbirimguncel");

                entity.Property(e => e.uzmanpersonelekle).HasColumnName("uzmanpersonelekle");
                entity.Property(e => e.uzmanpersonelsil).HasColumnName("uzmanpersonelsil");
                entity.Property(e => e.uzmanpersonelguncel).HasColumnName("uzmanpersonelguncel");

                entity.Property(e => e.uzmanilacekle).HasColumnName("uzmanilacekle");
                entity.Property(e => e.uzmanilacsil).HasColumnName("uzmanilacsil");

                entity.Property(e => e.uzmantaniekle).HasColumnName("uzmantaniekle");
                entity.Property(e => e.uzmantanisil).HasColumnName("uzmantanisil");

                entity.Property(e => e.uzmanstatuekle).HasColumnName("uzmanstatuekle");
                entity.Property(e => e.uzmanstatusil).HasColumnName("uzmanstatusil");
            });
        }
    }
}
