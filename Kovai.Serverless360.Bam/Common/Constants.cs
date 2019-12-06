﻿namespace Kovai.Serverless360.Bam
{
    public class Constants
    {
#if DEBUG
        public const string FunctionUrlPattern = "https://sl360-stag-bam.azurewebsites.net";
#else
        public const string FunctionUrlPattern = "https://sl360-prod-BAM-functionapp.azurewebsites.net";
#endif

        internal class Headers
        {
            public const string BusinessProcess = "SL360-BusinessProcess";
            public const string Transaction = "SL360-Transaction";
            public const string Stage = "SL360-Stage";
            public const string TransactionInstanceId = "SL360-TransactionInstanceId";
            public const string StageInstanceId = "SL360-StageInstanceId";
            public const string ArchiveMessage = "SL360-ArchiveMessage";
            public const string BatchId = "SL360-BatchId";
            public const string StageStatus = "SL360-StageStatus";
            public const string Exception = "SL360-Exception";
            public const string IsTransactionComplete = "SL360-IsTransactionComplete";
        }

        internal class Operations
        {
            public const string StartTransaction = "StartTransaction";
            public const string CheckPoint = "CheckPoint";
            public const string CorrelationCheckPoint = "CheckPointWithCorrelation";
        }
    }
}
