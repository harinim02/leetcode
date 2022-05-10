public class UndergroundSystem
    {
        private readonly Dictionary<int, string> checkin;
        private readonly Dictionary<string, double> totalTimeDict;
        private readonly Dictionary<string, int> totalUnitsDict;
        public UndergroundSystem()
        {
            checkin = new Dictionary<int, string>();
            totalTimeDict = new Dictionary<string, double>();
            totalUnitsDict = new Dictionary<string, int>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            // checkin dictionary
            stationName = stationName.ToLower();
            checkin.Add(id, $"{stationName}:{t}");
        }

        public void CheckOut(int id, string stationName, int t)
        {
            stationName = stationName.ToLower();
            checkin.TryGetValue(id, out var checkout);
            checkin.Remove(id);
            var checkinSplit = checkout.Split(':');
            var startStation = checkinSplit[0];
            double.TryParse(checkinSplit[1], out var startTime);

            var dictKey = $"{startStation}:{stationName}";
            totalTimeDict.TryGetValue(dictKey, out var totalTime);
            var travelTime = Math.Abs(t - startTime);
            totalUnitsDict.TryGetValue(dictKey, out var totalUnits);
            
            totalUnitsDict[dictKey] = totalUnits+1;
            totalTimeDict[dictKey] = totalTime + travelTime;
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            startStation = startStation.ToLower();
            endStation = endStation.ToLower();
            totalTimeDict.TryGetValue($"{startStation}:{endStation}", out var totalTime);
            totalUnitsDict.TryGetValue($"{startStation}:{endStation}", out var totalUnits);
            return totalTime / totalUnits;
        }
    }

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */