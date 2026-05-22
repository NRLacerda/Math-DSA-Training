namespace DSA.Challenges.MeetingRooms
{
    public class MeetingRooms
    {
        public int MinimumAmountOfRooms(int[][] meets)
        {
            if(meets.Length == 0){
                return 0;
            }

            int maxRooms = 0;
            for(int i = 0; i < meets.Length; i++)
            {
                int roomsNeededAtThisMeeting = 1;
                
                for(int j = 0; i < meets.Length; j++)
                {
                    if(i == j) contine; // to prevent first iteration logic/

                    bool overlaps = meets[i][0] < meets[j][1] && meets[j][0] < meets[i][1];

                    if(overlaps) roomsNeededAtThisMeeting++;
                }

                maxRooms = Math.Max(maxRooms, roomsNeededAtThisMeeting);

            }

            return maxRooms;
        }
    }
}