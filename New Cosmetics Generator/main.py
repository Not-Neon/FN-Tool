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
            if set1 == "Arcane: League of Legends":
                urllib.request.urlretrieve(icon, f'{name}.png')
                icons = Image.open(f'{name}.png')
                icons.save(f'{name}.png')
            print(f'Part of set: {set1}, {set2}')
        '''if name == "Shadow Midas":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')'''

        #urllib.request.urlretrieve(icon, f'{name}.png')
        #icons = Image.open(f'{name}.png')
        #icons.save(f'{name}.png')
        '''urllib.request.urlretrieve(icon, f'{itemID}.png')
        icons = Image.open(f'{itemID}.png')
        icons.save(f'{itemID}.png')'''

        '''images = [Image.open(x) for x in icon]
        widths, heights = zip(*(i.size for i in images))
        total_width = sum(widths)
        max_height = max(heights)
        new_im = Image.new('RGB', (total_width, max_height))
        x_offset = 0
        for im in images:
            new_im.paste(im, (x_offset, 0))
            x_offset += im.size[0]
        new_im.save('merged.png')'''

        # merge images
        '''
        images = [Image.open(x) for x in ['Chani.png', "Chani's Satchel.png", 'Fremkit.png', 'Maker Hooks.png', 'Paul Atreides.png', 'Sand Walk.png', 'The Stickworm.png', 'Twinblades.png']]
        widths, heights = zip(*(i.size for i in images))
        total_width = sum(widths)
        max_height = max(heights)
        new_im = Image.new('RGB', (total_width, max_height))
        x_offset = 0
        for im in images:
            new_im.paste(im, (x_offset, 0))
            x_offset += im.size[0]
        new_im.save('merged.png')
        '''

        # saving specific images
        '''
        if name == "Chani":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Paul Atreides":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Chani's Satchel":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Fremkit":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Maker Hooks":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Twinblades":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Sand Walk":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "Orinthopter":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        elif name == "The Stickworm":
            urllib.request.urlretrieve(icon, f'{name}.png')
            icons = Image.open(f'{name}.png')
            icons.save(f'{name}.png')
        '''

    print(f'\nTotal Cosmetics added in {build} = {item_count}')



new_cosmetics()