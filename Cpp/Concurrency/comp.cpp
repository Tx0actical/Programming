#include <iostream>
#include <vector>

class GameArrayClass {
    public : 
        int     length;
        bool    IsRedColor, CellValidity, JohnTurnIndicator, BotTurnIndicator, Switch, SwitchOverride;
        std::vector<int> CellArray;
} GameArrayobject;

int main() {
    using namespace std;
    
    int Testcase, BotMoveCount = 0, JohnMoveCount = 0, FinalBotScore, FinalJohnScore;
    
    cin >> Testcase;
    
    if(((Testcase >= 1) && (Testcase <= 6)) || ((Testcase >=1) && (Testcase <=100))) {
        while (Testcase) {
            cin >> GameArrayobject.length;

            if(((GameArrayobject.length >= 1) && (GameArrayobject.length <= 6)) || ((GameArrayobject.length >= 1) && (GameArrayobject.length <= 1000000))) {
                for (int i = 0; i <= GameArrayobject.length; i++) {

                    GameArrayobject.Switch = i % 2;

                    // logic to schedule turns for both players
                    if((GameArrayobject.Switch != 0) && (GameArrayobject.SwitchOverride = false)) {
                        GameArrayobject.BotTurnIndicator    = true;
                        GameArrayobject.JohnTurnIndicator   = false;
                    } else if ((GameArrayobject.Switch != 0) && (GameArrayobject.SwitchOverride = true)) {
                        GameArrayobject.JohnTurnIndicator   = false;
                        GameArrayobject.BotTurnIndicator    = false;
                    } else if ((GameArrayobject.Switch == 0) && (GameArrayobject.SwitchOverride = false)) {
                        GameArrayobject.JohnTurnIndicator   = true;
                        GameArrayobject.BotTurnIndicator    = false; 
                    } else if ((GameArrayobject.Switch == 0) && (GameArrayobject.SwitchOverride = true)) {
                        GameArrayobject.JohnTurnIndicator   = false;
                        GameArrayobject.BotTurnIndicator    = false;
                    }

                    if(GameArrayobject.BotTurnIndicator) {
                        if(i == 0) {
                            GameArrayobject.IsRedColor = true;
                            BotMoveCount++;
                        }
                    } else if (GameArrayobject.JohnTurnIndicator) {
                        GameArrayobject.IsRedColor = true;
                        JohnMoveCount++;
                    }

                    for (const int& i : GameArrayobject.CellArray) {
                        
                        // Check if each element is valid or not based on the color of adjacent elements
                        if(GameArrayobject.IsRedColor) {
                            GameArrayobject.CellValidity = true;
                        } else {
                            GameArrayobject.CellValidity = false;
                        }

                        // calculate the final score based upon the turn each player took
                        if(GameArrayobject.JohnTurnIndicator) {
                            FinalJohnScore = JohnMoveCount++;
                        } else if (GameArrayobject.BotTurnIndicator) {
                            FinalBotScore = BotMoveCount++;
                        }

                        // output the final score for all test cases
                        cout << "#Case " << i <<  ": " << FinalBotScore << endl;
                    }
                }
            }
            Testcase--;
        }
    }
}