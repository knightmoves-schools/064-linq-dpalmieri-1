namespace knightmoves;
using static StateList;
public class StateLookUp{

    public IEnumerable<string> LookUp(string search){
        var matches = new List<string>();

        foreach(string state in STATES){
            if(state.StartsWith(search)){
                matches.Add(state);
            }
        }

        return matches;
    }
}
