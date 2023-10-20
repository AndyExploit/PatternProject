namespace PatternProject.Domain.Entities.Base
{
    public class ExecuteQueryResponse<T>
    {
        #region PROPERTIES
        public int RowsAffected { get; set; }
        public string Message { get; set; }
        public T ReturnValue { get; set; }
        #endregion
    }
}
