using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.dto
{
    /// <summary>
    /// Dock object
    /// </summary>
    public class Dock
    {
        /// <summary>
        /// Property for DockId
        /// </summary>
        /// <value>
        /// Contains the docks unique id
        /// </value>
        public int DockId { get; set; }
        /// <summary>
        /// Property for DockName
        /// </summary>
        /// <value>
        /// Contains docks name
        /// </value>
        public string DockName { get; set; }
        /// <summary>
        /// Property for FerryCapacity
        /// </summary>
        /// <value>
        /// Contains the capatity a dock can contain
        /// </value>
        public int FerryCapacity { get; set; }
    }
}
