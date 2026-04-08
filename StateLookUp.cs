namespace knightmoves;
using static StateList;
public class StateLookUp{

    public IEnumerable<string> LookUp(string search){

        var matches = from state in STATES 
                          where state.StartsWith(search) 
                          orderby state ascending
                          select state;
        return matches;
    }
}
