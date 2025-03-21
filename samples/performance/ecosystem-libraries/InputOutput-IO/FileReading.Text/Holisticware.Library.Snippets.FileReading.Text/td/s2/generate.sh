#!/bin/bash

# Generate a 100-byte file

dd if=/dev/urandom of=random_100_bytes.txt bs=100 count=1

# Generate a 200-byte file
dd if=/dev/urandom of=random_200_bytes.txt bs=200 count=1

# Generate a 500-byte file
dd if=/dev/urandom of=random_500_bytes.txt bs=500 count=1

# Generate a 1-kilobyte (1024 bytes) file
dd if=/dev/urandom of=random_1kb.txt bs=1024 count=1


# Generate a 100-byte text file
base64 /dev/urandom | head -c 100 > random_100_bytes.txt

# Generate a 200-byte text file
base64 /dev/urandom | head -c 200 > random_200_bytes.txt

# Generate a 500-byte text file
base64 /dev/urandom | head -c 500 > random_500_bytes.txt

# Generate a 1-kilobyte (1024 bytes) text file
base64 /dev/urandom | head -c 1024 > random_1kb.txt
