using System;
public class Robot2 {
    public void Start () {

        string[] xy = Console.ReadLine ().Split (' ');
        int x = int.Parse (xy[0]);
        int y = int.Parse (xy[1]);
        string[] stepUnit = Console.ReadLine ().Split (' ');
        int Fs = int.Parse (stepUnit[0]);
        int Rs = int.Parse (stepUnit[1]);
        int Bs = int.Parse (stepUnit[2]);
        int Ls = int.Parse (stepUnit[3]);
        int loop = int.Parse (Console.ReadLine ());

        int angle = 0;

        for (int i = 0; i < loop; i++) {
            string[] command = Console.ReadLine ().Split (' ');
            string move = command[0];
            string dir = command[1];

            if (move == "t") {
                switch (dir) {
                    case "R":
                        angle = (angle + 1) % 4;
                        break;
                    case "B":
                        angle = (angle + 2) % 4;
                        break;
                    case "L":
                        angle = (angle + 3) % 4;
                        break;
                }

            } else {
                if (angle == 0) {
                    switch (dir) {
                        case "F":
                            y += Fs;
                            break;
                        case "R":
                            x += Rs;
                            break;
                        case "B":
                            y -= Bs;
                            break;
                        case "L":
                            x -= Ls;
                            break;
                    }
                } else if (angle == 1) {
                    switch (dir) {
                        case "F":
                            x += Fs;
                            break;
                        case "R":
                            y -= Rs;
                            break;
                        case "B":
                            x -= Bs;
                            break;
                        case "L":
                            y += Ls;
                            break;
                    }
                } else if (angle == 2) {
                    switch (dir) {
                        case "F":
                            y -= Fs;
                            break;
                        case "R":
                            x -= Rs;
                            break;
                        case "B":
                            y += Bs;
                            break;
                        case "L":
                            x += Ls;
                            break;
                    }
                } else if (angle == 3) {
                    switch (dir) {
                        case "F":
                            x -= Fs;
                            break;
                        case "R":
                            y += Rs;
                            break;
                        case "B":
                            x += Bs;
                            break;
                        case "L":
                            y -= Ls;
                            break;
                    }
                }
            }

        }
        Console.WriteLine (x + " " + y);
    }
}