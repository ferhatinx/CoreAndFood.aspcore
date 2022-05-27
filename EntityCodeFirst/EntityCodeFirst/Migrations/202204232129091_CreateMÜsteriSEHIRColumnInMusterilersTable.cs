namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMÜsteriSEHIRColumnInMusterilersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musterilers", "MüsteriSEHIR", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musterilers", "MüsteriSEHIR");
        }
    }
}
