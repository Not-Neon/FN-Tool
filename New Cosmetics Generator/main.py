import requests
import urllib.request
from PIL import Image


def new_cosmetics():
    api = 'https://fortnite-api.com/v2/cosmetics/br/new'
    json = requests.get(api).json()
    status = json['status']
    build = json['data']['build']
    prevBuild = json['data']['previousBuild']
    data = json['data']['items']
    item_count = 0
    print(f"Status = {status}\nBuild = {build}\nPrevious Build = {prevBuild}")
    for cosmetics in data:
        item_count = item_count + 1
        itemID = cosmetics['id']
        name = cosmetics['name']
        desc = cosmetics['description']
        rarity = cosmetics['rarity']['displayValue']
        backendRar = cosmetics['rarity']['backendValue']
        icon = cosmetics['images']['icon']
        print(f"\nItem Name = {name}\nID = {itemID}\nItem Description = {desc}\nDisplay Rarity = {rarity}\nBack End Rarity = {backendRar}")
        if cosmetics['set'] is not None:
            set1 = cosmetics['set']['value']
            set2 = cosmetics['set']['text']
            print(f'Part of set: {set1}, {set2}')

        urllib.request.urlretrieve(icon, f'{name}.png')
        icons = Image.open(f'{name}.png')
        icons.save(f'{name}.png')
        
        ## can be saved with item ID's too.
        '''urllib.request.urlretrieve(icon, f'{itemID}.png')
        icons = Image.open(f'{itemID}.png')
        icons.save(f'{itemID}.png')'''
        '''

    print(f'\nTotal Cosmetics added in {build} = {item_count}')



new_cosmetics()
