﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Equipment;

namespace Builder
{
    public interface IDecision
    {
        DateTime GetStartTime();
        DateTime GetEndTime();
        SingleEquipment GetEquipment();
        Operation GetOperation();
    }

    /// <summary>
    /// Class for saved operation to decision
    /// </summary>
    public class Decision:IDecision
    {
        private DateTime start_time;//real start time of operation in plan
        private DateTime end_time;// real end time of operation in plan
        private SingleEquipment equipment_id;//real id of equipment for this operation in plan
        private Operation op;//operation for this decision

        public Decision(DateTime start_time_, DateTime end_time_, SingleEquipment equipment_id_, Operation op_)
        {
            start_time = start_time_;
            end_time = end_time_;
            equipment_id = equipment_id_;
            op = op_;
        }

        /// <summary>
        /// Get real start time of operation in plan
        /// </summary>   
        public DateTime GetStartTime()
        {
            return start_time;
        }

        /// <summary>
        /// Get real end time of operation in plan
        /// </summary>   
        public DateTime GetEndTime()
        {
            return end_time;
        }

        /// <summary>
        /// Get real id of equipment for this operation in plan
        /// </summary>   
        public SingleEquipment GetEquipment()
        {
            return equipment_id;
        }

        /// <summary>
        /// Get operation for this decision
        /// </summary>   
        public Operation GetOperation()
        {
            return op;
        }
    }
}
