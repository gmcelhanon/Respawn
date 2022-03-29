namespace Respawn.Graph
{
    public class TemporalTable
    {
        public TemporalTable(string schema, string name, string historySchema, string historyTableName)
        {
            Schema = schema;
            Name = name;
            HistorySchema = historySchema;
            HistoryTableName = historyTableName;
        }

        public string Schema { get; }
        public string Name { get; }
        public string HistorySchema { get; }
        public string HistoryTableName { get; }
    }
}
