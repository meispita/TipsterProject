namespace TipsterData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        LastUpDateTime = c.DateTime(nullable: false),
                        CurrentSeason_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seasons", t => t.CurrentSeason_Id)
                .Index(t => t.CurrentSeason_Id);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        CurrentMatchday = c.Int(nullable: false),
                        Competition_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id)
                .Index(t => t.Competition_Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AwayTeam_Id = c.Long(),
                        Competition_Id = c.Long(),
                        HomeTeam_Id = c.Long(),
                        Score_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.AwayTeam_Id)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id)
                .ForeignKey("dbo.Teams", t => t.HomeTeam_Id)
                .ForeignKey("dbo.Scores", t => t.Score_Id)
                .Index(t => t.AwayTeam_Id)
                .Index(t => t.Competition_Id)
                .Index(t => t.HomeTeam_Id)
                .Index(t => t.Score_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HomeTeam = c.Int(nullable: false),
                        AwayTeam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stadings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Away_Id = c.Long(),
                        Home_Id = c.Long(),
                        season_Id = c.Long(),
                        Total_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.Away_Id)
                .ForeignKey("dbo.Tables", t => t.Home_Id)
                .ForeignKey("dbo.Seasons", t => t.season_Id)
                .ForeignKey("dbo.Tables", t => t.Total_Id)
                .Index(t => t.Away_Id)
                .Index(t => t.Home_Id)
                .Index(t => t.season_Id)
                .Index(t => t.Total_Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        PlayedGames = c.Int(nullable: false),
                        Won = c.Int(nullable: false),
                        Draw = c.Int(nullable: false),
                        Lost = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        GoalsFor = c.Int(nullable: false),
                        GoalsAgainst = c.Int(nullable: false),
                        GoalDifference = c.Int(nullable: false),
                        Team_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stadings", "Total_Id", "dbo.Tables");
            DropForeignKey("dbo.Stadings", "season_Id", "dbo.Seasons");
            DropForeignKey("dbo.Stadings", "Home_Id", "dbo.Tables");
            DropForeignKey("dbo.Stadings", "Away_Id", "dbo.Tables");
            DropForeignKey("dbo.Tables", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Score_Id", "dbo.Scores");
            DropForeignKey("dbo.Matches", "HomeTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Competition_Id", "dbo.Competitions");
            DropForeignKey("dbo.Matches", "AwayTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Seasons", "Competition_Id", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "CurrentSeason_Id", "dbo.Seasons");
            DropIndex("dbo.Tables", new[] { "Team_Id" });
            DropIndex("dbo.Stadings", new[] { "Total_Id" });
            DropIndex("dbo.Stadings", new[] { "season_Id" });
            DropIndex("dbo.Stadings", new[] { "Home_Id" });
            DropIndex("dbo.Stadings", new[] { "Away_Id" });
            DropIndex("dbo.Matches", new[] { "Score_Id" });
            DropIndex("dbo.Matches", new[] { "HomeTeam_Id" });
            DropIndex("dbo.Matches", new[] { "Competition_Id" });
            DropIndex("dbo.Matches", new[] { "AwayTeam_Id" });
            DropIndex("dbo.Seasons", new[] { "Competition_Id" });
            DropIndex("dbo.Competitions", new[] { "CurrentSeason_Id" });
            DropTable("dbo.Tables");
            DropTable("dbo.Stadings");
            DropTable("dbo.Scores");
            DropTable("dbo.Teams");
            DropTable("dbo.Matches");
            DropTable("dbo.Seasons");
            DropTable("dbo.Competitions");
        }
    }
}
