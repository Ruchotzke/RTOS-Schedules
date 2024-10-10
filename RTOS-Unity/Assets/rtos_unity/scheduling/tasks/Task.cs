namespace rtos_unity.scheduling.tasks
{
    /// <summary>
    /// A simple periodic task.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// The task's name.
        /// </summary>
        public string Name;
        
        /// <summary>
        /// The task's period.
        /// </summary>
        public float Period;
        
        /// <summary>
        /// The task's computation time.
        /// </summary>
        public float Computation;

        /// <summary>
        /// Generate a new task.
        /// </summary>
        /// <param name="name">Task name.</param>
        /// <param name="period">Task period.</param>
        /// <param name="comp">Computation time.</param>
        public Task(string name, float period, float comp)
        {
            Name = name;
            Period = period;
            Computation = comp;
        }
    }
}