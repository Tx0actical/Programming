import os
from os import path
from datetime import date, datetime, time, timedelta
import string
import time

def main():
    # Print OS name
    print(os.name)

    # check for item existence and type
    print("Item exists:", str(path.exists("textfile")))
    print("Item is a file:", path.isfile("textfile"))
    print("Item is a directory:", path.isdir("textfile"))

    # Working with filepath
    print("Item's full path:", path.realpath("textfile"))
    print("Item's path and name:", path.realpath("textfile"), path.split(path.realpath("textfile")))

    # Get information on file modification time
    t = time.ctime(path.getmtime("textfile"))
    print(t)
    print(datetime.fromtimestamp(path.getmtime("textfile")))

    # calculate how long ago the item was modified
    td = datetime.now() - datetime.fromtimestamp(path.getmtime("textfile"))
    print("It has been", td, "since the file was modified")
    print("Or", td.total_seconds(), "seconds")

if __name__ == "__main__" : main()