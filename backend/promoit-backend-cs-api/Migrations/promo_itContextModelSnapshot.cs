﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using promoit_backend_cs_api.Data;

#nullable disable

namespace promoit_backend_cs_api.Migrations
{
    [DbContext(typeof(promo_itContext))]
    partial class promo_itContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("promoit_backend_cs_api.Models.Bcr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("create_user_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("update_user_id");

                    b.Property<int>("UserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("BCR", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.BcrShip", b =>
                {
                    b.Property<int>("BcrId")
                        .HasColumnType("int")
                        .HasColumnName("BCR_id");

                    b.Property<int>("CampaignId")
                        .HasColumnType("int")
                        .HasColumnName("campaign_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<int>("ProductBought")
                        .HasColumnType("int")
                        .HasColumnName("product_bought");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int")
                        .HasColumnName("product_price");

                    b.Property<int>("ProductReady")
                        .HasColumnType("int")
                        .HasColumnName("product_ready");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasIndex("BcrId");

                    b.HasIndex("CampaignId");

                    b.HasIndex("ProductId");

                    b.ToTable("BCR_ship", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<string>("Hashtag")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("hashtag");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("link");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("NprId")
                        .HasColumnType("int")
                        .HasColumnName("NPR_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasKey("Id");

                    b.HasIndex("NprId");

                    b.HasIndex("StatusId");

                    b.ToTable("campaign", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.NonProfitRepresentative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("create_user_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("OrganizationLink")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("organization_link");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("organization_name");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("update_user_id");

                    b.Property<int>("UserId")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("non_profit_representative", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BcrId")
                        .HasColumnType("int")
                        .HasColumnName("BCR_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.Property<int>("Value")
                        .HasColumnType("int")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("BcrId");

                    b.HasIndex("StatusId");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.ProductStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("product_status", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.ProductToCampaign", b =>
                {
                    b.Property<int>("Id")
                       .ValueGeneratedOnAdd()
                       .HasColumnType("int")
                       .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoughtNumber")
                        .HasColumnType("int")
                        .HasColumnName("bought_number");

                    b.Property<int>("CampaignId")
                        .HasColumnType("int")
                        .HasColumnName("campaign_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<int>("InititalNumber")
                        .HasColumnType("int")
                        .HasColumnName("initital_number");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("product_to_campaign", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("role_name");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Sa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<string>("Twitter")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("twitter");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("SA", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.SaTransaction", b =>
                {
                    b.Property<int>("BcrId")
                        .HasColumnType("int")
                        .HasColumnName("BCR_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("ProductsNumber")
                        .HasColumnType("int")
                        .HasColumnName("products_number");

                    b.Property<int>("SaId")
                        .HasColumnType("int")
                        .HasColumnName("SA_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<int>("TransactionStatusId")
                        .HasColumnType("int")
                        .HasColumnName("transaction_status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasIndex("BcrId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TransactionStatusId");

                    b.ToTable("SA_transaction", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Status1")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("status", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.TransactionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TransactionStatus1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("transaction_status");

                    b.HasKey("Id");

                    b.ToTable("transaction_status", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("last_name");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("StatusId");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.SaToCampaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .HasColumnType("int")
                        .HasColumnName("campaign_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int")
                        .HasColumnName("create_user_id");

                    b.Property<int?>("Money")
                        .HasColumnType("int")
                        .HasColumnName("money");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("update_date");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("update_user_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("user_to_campaign", (string)null);
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Bcr", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Bcrs")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_BCR_status");

                    b.Navigation("Status");

                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.BcrShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasOne("promoit_backend_cs_api.Models.Bcr", "Bcr")
                        .WithMany()
                        .HasForeignKey("BcrId")
                        .IsRequired()
                        .HasConstraintName("FK_BCR_ship_BCR");

                    b.HasOne("promoit_backend_cs_api.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .IsRequired()
                        .HasConstraintName("FK_BCR_ship_campaign");

                    b.HasOne("promoit_backend_cs_api.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_BCR_ship_product");

                    b.Navigation("Bcr");

                    b.Navigation("Campaign");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Campaign", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.NonProfitRepresentative", "Npr")
                        .WithMany("Campaigns")
                        .HasForeignKey("NprId")
                        .IsRequired()
                        .HasConstraintName("FK_campaign_non_profit_representative");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Campaigns")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_campaign_status");

                    b.Navigation("Npr");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.NonProfitRepresentative", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("NonProfitRepresentatives")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_non_profit_representative_status");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Product", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Bcr", "Bcr")
                        .WithMany("Products")
                        .HasForeignKey("BcrId")
                        .IsRequired()
                        .HasConstraintName("FK_product_BCR");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Products")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_product_status");

                    b.Navigation("Bcr");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.ProductToCampaign", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .IsRequired()
                        .HasConstraintName("FK_product_to_campaign_campaign");

                    b.HasOne("promoit_backend_cs_api.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_product_to_campaign_product");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_product_to_campaign_status");

                    b.Navigation("Campaign");

                    b.Navigation("Product");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Role", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Roles")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_role_status");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Sa", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Sas")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_status");

                    b.HasOne("promoit_backend_cs_api.Models.User", "User")
                        .WithMany("Sas")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_user");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.SaTransaction", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Bcr", "Bcr")
                        .WithMany()
                        .HasForeignKey("BcrId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_transaction_BCR");

                    b.HasOne("promoit_backend_cs_api.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_transaction_product");

                    b.HasOne("promoit_backend_cs_api.Models.Sa", "Sa")
                        .WithMany()
                        .HasForeignKey("SaId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_transaction_SA");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_transaction_status");

                    b.HasOne("promoit_backend_cs_api.Models.TransactionStatus", "TransactionStatus")
                        .WithMany()
                        .HasForeignKey("TransactionStatusId")
                        .IsRequired()
                        .HasConstraintName("FK_SA_transaction_transaction_status");

                    b.Navigation("Bcr");

                    b.Navigation("Product");

                    b.Navigation("Sa");

                    b.Navigation("Status");

                    b.Navigation("TransactionStatus");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.User", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_user_role");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany("Users")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_user_status");

                    b.Navigation("Role");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.SaToCampaign", b =>
                {
                    b.HasOne("promoit_backend_cs_api.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .IsRequired()
                        .HasConstraintName("FK_sa_to_campaign_campaign");

                    b.HasOne("promoit_backend_cs_api.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_sar_to_campaign_status");

                    b.HasOne("promoit_backend_cs_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("SaId")
                        .IsRequired()
                        .HasConstraintName("FK_sa_to_campaign_sa");

                    b.Navigation("Campaign");

                    b.Navigation("Status");

                    b.Navigation("Sa");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Bcr", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.NonProfitRepresentative", b =>
                {
                    b.Navigation("Campaigns");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("promoit_backend_cs_api.Models.Status", b =>
                {
                    b.Navigation("Bcrs");

                    b.Navigation("Campaigns");

                    b.Navigation("NonProfitRepresentatives");

                    b.Navigation("Products");

                    b.Navigation("Roles");

                    b.Navigation("Sas");

                    b.Navigation("Users");
                });

#pragma warning restore 612, 618
        }
    }
}