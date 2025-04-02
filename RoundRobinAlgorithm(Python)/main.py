import tkinter as tk
from tkinter import messagebox
from tkinter import ttk


# Round Robin Scheduling Algorithm
def round_robin_scheduling(processes, burst_times, quantum):
    n = len(processes)
    remaining_burst_times = burst_times[:]
    time = 0
    waiting_time = [0] * n
    turnaround_time = [0] * n
    finished = [False] * n
    cycle_logs = []

    while True:
        done = True
        for i in range(n):
            if remaining_burst_times[i] > 0:
                done = False
                current_time = 0
                if remaining_burst_times[i] > quantum:
                    time += quantum
                    current_time = quantum
                    remaining_burst_times[i] -= quantum
                else:
                    current_time = remaining_burst_times[i]
                    time += remaining_burst_times[i]
                    remaining_burst_times[i] = 0
                    waiting_time[i] = time - burst_times[i]
                    finished[i] = True

                # Log the process information in this cycle
                cycle_logs.append((time, processes[i], current_time, remaining_burst_times[i]))

        if done:
            break

    for i in range(n):
        turnaround_time[i] = burst_times[i] + waiting_time[i]

    return waiting_time, turnaround_time, cycle_logs


# Function to handle scheduling button click
def schedule_processes():
    try:
        processes = [f"P{i + 1}" for i in range(int(num_processes_entry.get()))]
        burst_times = list(map(int, burst_times_entry.get().split()))
        quantum = int(quantum_entry.get())

        if len(burst_times) != len(processes):
            raise ValueError("The number of processes does not match the burst times.")

        # Call the Round Robin Scheduling function
        waiting_time, turnaround_time, cycle_logs = round_robin_scheduling(processes, burst_times, quantum)

        # Clear previous results in the cycle logs table
        for row in cycle_tree.get_children():
            cycle_tree.delete(row)

        # Clear previous results in the final results table
        for row in result_tree.get_children():
            result_tree.delete(row)

        # Display the scheduling cycles in the TreeView (cycle logs)
        for log in cycle_logs:
            cycle_tree.insert("", "end", values=log)

        # Display the final results (waiting time and turnaround time)
        for i in range(len(processes)):
            result_tree.insert("", "end", values=(processes[i], waiting_time[i], turnaround_time[i]))

    except ValueError as ve:
        messagebox.showerror("Error", f"Input Error: {ve}")
    except Exception as e:
        messagebox.showerror("Error", f"An unexpected error occurred: {e}")


# User Interface
root = tk.Tk()
root.title("Round Robin Scheduler")

# Input fields
tk.Label(root, text="Number of Processes:").grid(row=0, column=0)
num_processes_entry = tk.Entry(root, justify="left")
num_processes_entry.grid(row=0, column=1)

tk.Label(root, text="Burst Times:").grid(row=1, column=0)
burst_times_entry = tk.Entry(root, justify="left")
burst_times_entry.grid(row=1, column=1)

tk.Label(root, text="Time Quantum:").grid(row=2, column=0)
quantum_entry = tk.Entry(root, justify="left")
quantum_entry.grid(row=2, column=1)

# Schedule button
schedule_button = tk.Button(root, text="Schedule", command=schedule_processes)
schedule_button.grid(row=3, columnspan=2)

# Frame to hold the scheduling cycle table and its scrollbar
cycle_frame = tk.Frame(root)
cycle_frame.grid(row=4, columnspan=2, padx=10, pady=10)

# TreeView for displaying the scheduling cycles (Cycle Logs)
cycle_columns = ("Time", "Process", "Executed Time", "Remaining Time")
cycle_tree = ttk.Treeview(cycle_frame, columns=cycle_columns, show="headings", height=8)
cycle_tree.heading("Time", text="Time")
cycle_tree.heading("Process", text="Process")
cycle_tree.heading("Executed Time", text="Executed Time")
cycle_tree.heading("Remaining Time", text="Remaining Time")

# Add vertical scrollbar to the cycle table
cycle_scrollbar = ttk.Scrollbar(cycle_frame, orient="vertical", command=cycle_tree.yview)
cycle_tree.configure(yscroll=cycle_scrollbar.set)
cycle_tree.grid(row=0, column=0)
cycle_scrollbar.grid(row=0, column=1, sticky="ns")

# Label for the final results table
tk.Label(root, text="Final Results", font=("Arial", 12, "bold")).grid(row=5, columnspan=2, padx=10, pady=5)

# TreeView for displaying the final results (Waiting Time and Turnaround Time)
result_columns = ("Process", "Waiting Time", "Turnaround Time")
result_tree = ttk.Treeview(root, columns=result_columns, show="headings")
result_tree.heading("Process", text="Process")
result_tree.heading("Waiting Time", text="Waiting Time")
result_tree.heading("Turnaround Time", text="Turnaround Time")
result_tree.grid(row=6, columnspan=2, padx=10, pady=10)

root.mainloop()
