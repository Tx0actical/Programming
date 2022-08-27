from cgitb import text
import os, shutil
from os import path
from shutil import make_archive
from zipfile import ZipFile

def main():

    # make a duplicate of the existing file
    if path.exists("newfile"):
        # get the path to the file in the current directory
        src = path.realpath("textfile")

        # making a backup copy
        # dst = src + '.bak'
        # shutil.copy(src, dst)

        # rename original file
        # os.rename("textfile", "newfile")

        # put contents into ZIP archive
        root_dir, tail = path.split(src)
        shutil.make_archive("archive", "zip", root_dir)

        # more control!
        with ZipFile("testzip.zip", "w") as newzip:
            newzip.write("newfile")
            newzip.write("textfile.bak")


if __name__ == "__main__" : main()