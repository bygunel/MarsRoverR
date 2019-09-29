namespace MarsRoverR
{
    class Robot
    {
        #region RobotStatus
        private int currentLocationX = 1;
        private int currentLocationY = 1;
        private char currentDirection = 'N';

        public int CurrentLocationX { get => currentLocationX; set => currentLocationX = value; }
        public int CurrentLocationY { get => currentLocationY; set => currentLocationY = value; }
        public char CurrentDirection { get => currentDirection; set => currentDirection = value; }
        #endregion
        #region AreaInformation
        private int upperRightCoordinateX;
        private int upperRightCoordinateY;

        public int UpperRightCoordinateX { get => upperRightCoordinateX; set => upperRightCoordinateX = value; }
        public int UpperRightCoordinateY { get => upperRightCoordinateY; set => upperRightCoordinateY = value; }

        #endregion


        private bool InTheMap(int CoordinateX, int CoordinateY)
        {
            if (CoordinateX > upperRightCoordinateX || CoordinateY > upperRightCoordinateY)
                return false;

            return true;
        }
        private void NextMove(char nextMove)
        {
            // Left
            if (nextMove == 'L')
            {
                switch (currentDirection)
                {
                    case 'E':
                        currentDirection = 'N';
                        break;
                    case 'N':
                        currentDirection = 'W';
                        break;
                    case 'W':
                        currentDirection = 'S';
                        break;
                    case 'S':
                        currentDirection = 'E';
                        break;
                }
                return;
            }
            // Right
            if (nextMove == 'R')
            {
                switch (currentDirection)
                {
                    case 'E':
                        currentDirection = 'S';
                        break;
                    case 'S':
                        currentDirection = 'W';
                        break;
                    case 'W':
                        currentDirection = 'N';
                        break;
                    case 'N':
                        currentDirection = 'E';
                        break;
                }
                return;
            }
            // Move
            switch (currentDirection)
            {
                case 'E':
                    currentLocationX++;
                    break;
                case 'W':
                    currentLocationX--;
                    break;
                case 'N':
                    currentLocationY++;
                    break;
                case 'S':
                    currentLocationY--;
                    break;
            }
        }





        public string WhereIsRobot(string movementDirectives)
        {
            if (!InTheMap(currentLocationX, currentLocationY))
                return "First location is NOT valid !!!";


            int step = 0;
            foreach (char operation in movementDirectives)
            {
                step++;
                NextMove(operation);

                if (!InTheMap(currentLocationX, currentLocationY))
                    return string.Format("{0}. step operation invalid !!!", step);
            }


            return string.Format("{0} {1} {2}", currentLocationX, currentLocationY, currentDirection);

        }
    }
}
