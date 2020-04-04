// <auto-generated />
using System;
using MAVN.Service.BonusEngine.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.BonusEngine.MsSqlRepositories.Migrations
{
    [DbContext(typeof(BonusEngineContext))]
    [Migration("20190620073704_AddActiveCampaign")]
    partial class AddActiveCampaign
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("bonus_engine")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.BonusEngine.MsSqlRepositories.Entities.ActiveCampaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.HasKey("Id");

                    b.ToTable("ActiveCampaigns");
                });

            modelBuilder.Entity("MAVN.Service.BonusEngine.MsSqlRepositories.Entities.CampaignCompletionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("CampaignCompletionCount")
                        .HasColumnName("campaign_completion_count");

                    b.Property<Guid>("CampaignId")
                        .HasColumnName("campaign_id");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<bool>("IsCompleted")
                        .HasColumnName("is_completed");

                    b.HasKey("Id");

                    b.ToTable("campaign_completion");
                });

            modelBuilder.Entity("MAVN.Service.BonusEngine.MsSqlRepositories.Entities.ConditionCompletionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("CampaignId")
                        .HasColumnName("campaign_id");

                    b.Property<Guid>("ConditionEntityId")
                        .HasColumnName("condition_id");

                    b.Property<int>("CurrentCount")
                        .HasColumnName("current_count");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<bool>("IsCompleted")
                        .HasColumnName("is_completed");

                    b.Property<string>("_data")
                        .HasColumnName("data");

                    b.HasKey("Id");

                    b.ToTable("condition_completion");
                });
#pragma warning restore 612, 618
        }
    }
}
