/* Reflection Layout */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Layout;
using log4net.Layout.Pattern;
using System.IO;
using log4net.Core;
using System.Reflection;

namespace Log4Ext
{
    /// <summary>
    /// A flexible layout configurable with pattern string.
    /// </summary>
    public class ReflectionLayout : PatternLayout
    {
        /// <summary>
        /// Constructs a PatternLayout using the DefaultConversionPattern
        /// </summary>
        public ReflectionLayout()
        {
            this.AddConverter("property", typeof(ReflectionPatternConverter));
        }
    }

    /// <summary>
    /// Abstract class that provides the formatting functionality that derived classes need.
    /// </summary>
    public class ReflectionPatternConverter : PatternLayoutConverter
    {       
        /* \ \ 
           <summary>
           Derived pattern converters must override this method in order
           to convert
           
           conversion specifiers in the correct way.
           </summary>
           <param name="writer">System.IO.TextWriter that will
                                receive the formatted result.</param>
           <param name="loggingEvent">The log4net.Core.LoggingEvent on
                                      which the pattern converter
                                      should be executed.</param>        */
        protected override void Convert(System.IO.TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (Option != null)
            {                
                WriteObject(writer, loggingEvent.Repository, LookupProperty(Option, loggingEvent));
            }
            else
            {             
                WriteDictionary(writer, loggingEvent.Repository, loggingEvent.GetProperties());
            }
        }
        
        /* \ \ 
           <summary>
           get property from log4net.Core.LoggingEvent
           </summary>
           <param name="property">the name of the property</param>
           <param name="loggingEvent">_The log4net.Core.LoggingEvent on
                                      which the pattern converter
                                      should be executed.</param>
           <returns>
           property value 
           </returns>                                                   */
        private object LookupProperty(string property, log4net.Core.LoggingEvent loggingEvent)
        {
            object propertyValue = string.Empty;
            propertyValue = loggingEvent.Properties[property];

            return propertyValue;
        }
    }    
}
