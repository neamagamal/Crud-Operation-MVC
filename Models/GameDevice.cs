﻿namespace CrudOperation.Models
{
    public class GameDevice
    {
        public int GameId { get; set; }
        public Game game { get; set; } = default!;
        public int DeviceId { get; set; }
        public Device device { get; set; } = default!;


    }
}
