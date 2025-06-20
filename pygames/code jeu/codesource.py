import pygame
import sys

pygame.init()

window = pygame.display.set_mode((1000, 800))
pygame.display.set_caption("Menu")

WHITE = (255, 255, 255)

button = pygame.Rect(450, 350, 200, 50)

running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
            


pygame.quit()
sys.exit()