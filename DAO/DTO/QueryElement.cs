namespace SEA_ApiTest.DAO.DTO
{

    /// <summary>
    /// DAO共用的查詢物件
    /// </summary>
    public class QueryElement
    {
        public int? agentId { get; set; }
        public List<int>? roles { get; set; }
        public List<int>? agentIds { get; set; }
        public bool IsSEA_ApiTestT4 { get; set; } = false;
        public DateTime time { get; set; } = DateTime.Now;

        public bool hasRoles() => roles != null ? roles.Count > 0 : false;
        public bool hasAgentIds() => agentIds != null ? agentIds.Count > 0 : false;
    }
}
