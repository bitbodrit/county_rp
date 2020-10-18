﻿using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CountyRP.DAO
{
    public class Teleport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public float[] EntrancePosition
        {
            get { return JsonConvert.DeserializeObject<float[]>(_EntrancePosition); }
            set { _EntrancePosition = JsonConvert.SerializeObject(value); }
        }
        public uint EntranceDimension { get; set; }
        [NotMapped]
        public float[] ExitPosition
        {
            get { return JsonConvert.DeserializeObject<float[]>(_ExitPosition); }
            set { _ExitPosition = JsonConvert.SerializeObject(value); }
        }
        public uint ExitDimension { get; set; }
        public int TypeMarker { get; set; }
        [NotMapped]
        public int[] ColorMarker
        {
            get { return JsonConvert.DeserializeObject<int[]>(_ColorMarker); }
            set { _ColorMarker = JsonConvert.SerializeObject(value); }
        }
        public int TypeBlip { get; set; }
        public byte ColorBlip { get; set; }
        public string FactionId { get; set; }
        public int GangId { get; set; }
        public int RoomId { get; set; }
        public bool Lock { get; set; }

        [Column("EntrancePosition")]
        public string _EntrancePosition { get; set; }
        [Column("ExitPosition")]
        public string _ExitPosition { get; set; }
        [Column("ColorMarker")]
        public string _ColorMarker { get; set; }
    }
}
