namespace rtos_unity.scheduling.tasks
{
    /// <summary>
    /// An instance of a task.
    /// </summary>
    public class TaskInstance
    {
        /// <summary>
        /// The name of this instance.
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The arrival time of this instance.
        /// </summary>
        public readonly float Arrival;

        /// <summary>
        /// The deadline for this instance.
        /// </summary>
        public readonly float Deadline;

        /// <summary>
        /// The total computation time needed.
        /// </summary>
        public readonly float Computation;

        /// <summary>
        /// The progress towards completion.
        /// </summary>
        public float Progress;

        /// <summary>
        /// Generate a task instance from a task.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="instance"></param>
        /// <param name="arrival"></param>
        public TaskInstance(Task t, int instance, float arrival)
        {
            Name = t.Name + "_" + instance;
            Arrival = arrival;
            Deadline = arrival + t.Period;
            Computation = t.Computation;
            Progress = 0.0f;
        }
    }
}