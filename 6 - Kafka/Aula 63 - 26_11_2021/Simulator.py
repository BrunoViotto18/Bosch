# -*- coding: utf-8 -*-
"""
Created on Thu Nov 25 13:58:56 2021

@author: LIR6CT
"""
import os
import csv
import time
import uuid
from random import seed
from random import random

# Settings - - - - - - - - - - - - - - - - - - - - - - - - -
#attendees   = ['OJV9CT','LIR6CT','DUD9CT','REM2CT','OLV2CT','SHV2CT','ADN1CT','DEE3CT','LEA4CT','CAA3JVL','CGS3HO','GMF3CT','WMA3CT','NGA3CT','MLS3CT','MWA3CT','BIV3CT','MDA3CT','ZAQ9CT','GOR3CT','FEF2CT','PAU3CT','WOJ3CT','FAS9CT','GCG2CT','JNO3CT','USP2CT','GUD9CT','AAA2CT','OLF2CA','ROC1CT','GE72CA','ART2CA','MMR3CT','MSL3CT','SRS3CT','JLB3CT','FID3CT']

attendees = ['LIR6CT', 'CARLOS', 'MURILO', 'GABRIEL', 'MELISSA', 'NICHOLAS', 'ALLAN', 'LUIS', 'VINICIUS', 'BRUNO', 'ALEXANDRE', 'THIAGO', 'STACY', 'NATHAN', 'JOAO', 'ALISSON', 'LEONARDO', 'RAISSA', 'MARINA']
attendees = [x.lower() for x in attendees] # I know I'm lazy

stations    = ['stat010', 'stat020', 'stat030']
sleep_time  = 1

fs_root_path = r'S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\datastream'

class Station010:
    def __init__(self):
        self.timestamp = int(time.time())
        self.temp = 30 # Grad Celsius
        self.air_pressure = 1013 # hPa
        self.humidity = 45
        self.product = 'cri3'
        self.station = 'stat010'

    def print_values(self):
        print('Temp: {} Air Pressure: {} Humidity: {}'.format(self.temp, self.air_pressure, self.humidity))

    def update_values(self):
        self.timestamp = int(time.time())

        temp_movement = -1 if random() < 0.5 else 1
        self.temp = self.temp + temp_movement

        pressure_movement = -5 if random() < 0.5 else 5
        self.air_pressure = self.air_pressure + pressure_movement

        humidity_movement = -0.3 if random() < 0.5 else 0.3
        self.humidity = round(self.humidity + humidity_movement,1)
        if self.humidity < 0:
            self.humidity = 0


    def write_to_disk(self):
        for attendee in attendees:
            with open(os.path.join(fs_root_path, attendee, self.station, str(self.timestamp))+'.csv', 'w', newline='') as file:
                writer = csv.writer(file)
                writer.writerow(['time', 'temp', 'air_pressure', 'humidity', 'product', 'station'])
                writer.writerow([self.timestamp, self.temp, self.air_pressure, self.humidity, self.product, self.station])


def setup_attendees_dirs():
    for attendee in attendees:
        if not os.path.exists(os.path.join(fs_root_path, attendee)):
            os.makedirs(os.path.join(fs_root_path, attendee))
        for station in stations:
            if not os.path.exists(os.path.join(fs_root_path, attendee, station)):
                os.makedirs(os.path.join(fs_root_path, attendee, station))

# Initial Setup - - - - - - - - - - - - - - - - - - - - - - -
seed(1)

station010 = Station010()
#station020 = Station020()
#station030 = Station030()

# Main Loop - - - - - - - - - - - - - - - - - - - - - - - - -
while True:
    setup_attendees_dirs()
    
    # Station 010
    station010.update_values()
    station010.print_values()
    station010.write_to_disk()


    time.sleep(sleep_time)
