using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RoundRobinAlgorithm_Csharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Round Robin Scheduling Algorithm
        private (List<int> waitingTime, List<int> turnaroundTime, List<(int time, string process, int executedTime, int remainingTime)> cycleLogs)
        RoundRobinScheduling(List<string> processes, List<int> burstTimes, int quantum)
        {
            int n = processes.Count;
            List<int> remainingBurstTimes = new List<int>(burstTimes);
            List<int> waitingTime = new List<int>(new int[n]);
            List<int> turnaroundTime = new List<int>(new int[n]);
            bool[] finished = new bool[n];
            List<(int, string, int, int)> cycleLogs = new List<(int, string, int, int)>();

            int time = 0;
            while (true)
            {
                bool done = true;
                for (int i = 0; i < n; i++)
                {
                    if (remainingBurstTimes[i] > 0)
                    {
                        done = false;
                        int currentTime = 0;
                        if (remainingBurstTimes[i] > quantum)
                        {
                            time += quantum;
                            currentTime = quantum;
                            remainingBurstTimes[i] -= quantum;
                        }
                        else
                        {
                            currentTime = remainingBurstTimes[i];
                            time += remainingBurstTimes[i];
                            remainingBurstTimes[i] = 0;
                            waitingTime[i] = time - burstTimes[i];
                            finished[i] = true;
                        }

                        // Log the process information in this cycle
                        cycleLogs.Add((time, processes[i], currentTime, remainingBurstTimes[i]));
                    }
                }
                if (done)
                    break;
            }

            for (int i = 0; i < n; i++)
            {
                turnaroundTime[i] = burstTimes[i] + waitingTime[i];
            }

            return (waitingTime, turnaroundTime, cycleLogs);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                // Reading inputs from the textboxes
                int processCount = int.Parse(txtNumProcesses.Text);
                List<int> burstTimes = new List<int>(Array.ConvertAll(txtBurstTimes.Text.Split(' '), int.Parse));
                int quantum = int.Parse(txtQuantum.Text);

                if (burstTimes.Count != processCount)
                {
                    MessageBox.Show("The number of burst times does not match the number of processes.");
                    return;
                }

                // Create process list
                List<string> processes = new List<string>();
                for (int i = 0; i < processCount; i++)
                {
                    processes.Add($"P{i + 1}");
                }

                // Call Round Robin scheduling algorithm
                var (waitingTimes, turnaroundTimes, cycleLogs) = RoundRobinScheduling(processes, burstTimes, quantum);

                // Display cycle logs
                dgvCycleLogs.Rows.Clear();
                foreach (var log in cycleLogs)
                {
                    dgvCycleLogs.Rows.Add(log.time, log.process, log.executedTime, log.remainingTime);
                }

                // Display final results
                dgvFinalResults.Rows.Clear();
                for (int i = 0; i < processes.Count; i++)
                {
                    dgvFinalResults.Rows.Add(processes[i], waitingTimes[i], turnaroundTimes[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
