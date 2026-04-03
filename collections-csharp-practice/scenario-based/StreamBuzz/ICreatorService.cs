using System.Collections.Generic;

namespace StreamBuzz
{
    public interface ICreatorService
    {
        void RegisterCreator(CreatorStats record);

        Dictionary<string, int> GetTopPostCounts(
            List<CreatorStats> records,
            double likeThreshold
        );

        double CalculateAverageLikes();
    }
}
