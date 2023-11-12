import pickle
import os

def read_from_text_file(file_path):
    if not os.path.exists(file_path):
        # Create the file if it does not exist
        with open(file_path, 'w'):
            pass

    # Read from the file
    with open(file_path, 'r') as file:
        lines = file.readlines()
    return lines

def write_to_text_file(file_path, lines):
    with open(file_path, 'w') as file:
        for line in lines:
            file.write(line)

def write_to_binary_file(file_path, object_to_write):
    with open(file_path, 'wb') as file:
        pickle.dump(object_to_write, file)

def read_from_binary_file(file_path):
    if not os.path.exists(file_path):
        # Create the file if it does not exist
        with open(file_path, 'wb'):
            pass

    try:
        with open(file_path, 'rb') as file:
            read_object = pickle.load(file)
            return read_object
    except EOFError:
        return None  # or handle the error in your specific way
    except (pickle.UnpicklingError, FileNotFoundError):
        return None  # or handle the error in your specific way