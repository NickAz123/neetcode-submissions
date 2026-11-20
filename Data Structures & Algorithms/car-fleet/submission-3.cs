public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<double> fleets = new();
        List<int[]> cars = new List<int[]>();

        for(int i = 0; i < position.Length; i++){
            cars.Add([position[i], speed[i]]);
        }

        cars.Sort((x, y) => y[0].CompareTo(x[0]));

        foreach(int[] car in cars){
            double time = (double)(target - car[0]) / car[1];
            if(fleets.Count == 0){
                fleets.Push(time);
            } else if(time > fleets.Peek()){
                fleets.Push(time);
            }
        }
        return fleets.Count;
    }
}
