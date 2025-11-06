[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/DbUp/dbup-redshift.git")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Runtime.InteropServices.Guid("abcc04cc-0bd3-421e-9ae4-9fd0e4f4ef04")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v8.0", FrameworkDisplayName=".NET 8.0")]
public static class RedshiftExtensions
{
    public static DbUp.Builder.UpgradeEngineBuilder JournalToRedshiftTable(this DbUp.Builder.UpgradeEngineBuilder builder, string schema, string table) { }
    public static DbUp.Builder.UpgradeEngineBuilder RedshiftDatabase(DbUp.Engine.Transactions.IConnectionManager connectionManager) { }
    public static DbUp.Builder.UpgradeEngineBuilder RedshiftDatabase(this DbUp.Builder.SupportedDatabases supported, DbUp.Engine.Transactions.IConnectionManager connectionManager) { }
    public static DbUp.Builder.UpgradeEngineBuilder RedshiftDatabase(this DbUp.Builder.SupportedDatabases supported, string connectionString) { }
    public static DbUp.Builder.UpgradeEngineBuilder RedshiftDatabase(DbUp.Engine.Transactions.IConnectionManager connectionManager, string schema) { }
    public static void RedshiftDatabase(this DbUp.SupportedDatabasesForEnsureDatabase supported, string connectionString) { }
    public static DbUp.Builder.UpgradeEngineBuilder RedshiftDatabase(this DbUp.Builder.SupportedDatabases supported, string connectionString, string schema) { }
    public static void RedshiftDatabase(this DbUp.SupportedDatabasesForEnsureDatabase supported, string connectionString, DbUp.Engine.Output.IUpgradeLog logger) { }
}
namespace DbUp.Redshift
{
    public class RedshiftConnectionManager : DbUp.Engine.Transactions.DatabaseConnectionManager
    {
        public RedshiftConnectionManager(string connectionString) { }
        public override System.Collections.Generic.IEnumerable<string> SplitScriptIntoCommands(string scriptContents) { }
    }
    public class RedshiftObjectParser : DbUp.Support.SqlObjectParser
    {
        public RedshiftObjectParser() { }
    }
    public class RedshiftPreprocessor : DbUp.Engine.IScriptPreprocessor
    {
        public RedshiftPreprocessor() { }
        public string Process(string contents) { }
    }
    public class RedshiftScriptExecutor : DbUp.Support.ScriptExecutor
    {
        public RedshiftScriptExecutor(System.Func<DbUp.Engine.Transactions.IConnectionManager> connectionManagerFactory, System.Func<DbUp.Engine.Output.IUpgradeLog> log, string schema, System.Func<bool> variablesEnabled, System.Collections.Generic.IEnumerable<DbUp.Engine.IScriptPreprocessor> scriptPreprocessors, System.Func<DbUp.Engine.IJournal> journalFactory) { }
        protected override void ExecuteCommandsWithinExceptionHandler(int index, DbUp.Engine.SqlScript script, System.Action excuteCommand) { }
        protected override string GetVerifySchemaSql(string schema) { }
    }
    public class RedshiftTableJournal : DbUp.Support.TableJournal
    {
        public RedshiftTableJournal(System.Func<DbUp.Engine.Transactions.IConnectionManager> connectionManager, System.Func<DbUp.Engine.Output.IUpgradeLog> logger, string schema, string tableName) { }
        protected override string CreateSchemaTableSql(string quotedPrimaryKeyName) { }
        protected override string GetInsertJournalEntrySql(string scriptName, string applied) { }
        protected override string GetJournalEntriesSql() { }
    }
}