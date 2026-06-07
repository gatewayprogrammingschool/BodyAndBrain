## Non-Player Characters

_____

NPCs use the same race, profession, skill, resistance, attack, spell, armor, and maneuver rules as player characters. For important recurring characters, build the NPC as a full character. For a one-scene opponent or ally, use the quick generator below.

### NPC Generation

The quick generator uses target levels from 1 to 50 and starts from a level 5 adult base NPC. Level changes use an inverted bell curve: changes near level 5 are small, while changes farther from level 5 become increasingly significant.

1. Choose the NPC's target level from 1 to 50.
2. Calculate `Level Offset = Target Level - 5`.
3. Convert that offset into a signed `Level Significance Score`: `sign(Level Offset) x triangular(abs(Level Offset))`, where `triangular(n) = n x (n + 1) / 2`.
4. Choose a race, profession, apprenticeship, and role concept if the NPC is classed. For an unclassed creature, choose the closest attack profile, armor profile, and resistance profile.
5. Assign a level 5 stat array from [NPC Stat Arrays](#npc-stat-arrays), then apply the stat factor table, racial stat bonuses, and age modifiers from [Age Influence On Stats](#age-influence-on-stats). Clamp final stats to the normal character range of 1 to 100.
6. Assign level 5 skill baselines from the skill factor table, then apply the same `Level Significance Score`. Clamp final skill levels to the normal skill range of 0 to 10 unless the campaign deliberately allows epic skill levels.
7. Calculate bonuses normally from the resulting stats and skill levels.
8. Give the NPC one tactic, one goal, and one retreat or escalation condition.

### NPC Level Significance

The curve below makes level changes close to 5 modest, but makes each additional step away from level 5 more important than the previous step. Levels above 10 use the experienced-adult age modifier; their labels are power tiers rather than new age categories.

| Target Level | Life Stage / Tier | Level Offset | Level Significance Score | Step Meaning |
| --- | --- | --- | --- | --- |
| 1 | Apprentice / Adolescent | -4 | -10 | 4 steps below adult baseline; newest step -4 |
| 2 | Young Adult | -3 | -6 | 3 steps below adult baseline; newest step -3 |
| 3 | Young Adult | -2 | -3 | 2 steps below adult baseline; newest step -2 |
| 4 | Young Adult | -1 | -1 | 1 step below adult baseline; newest step -1 |
| 5 | Adult | 0 | 0 | Base adult NPC |
| 6 | Adult | +1 | +1 | 1 step above adult baseline; newest step +1 |
| 7 | Adult | +2 | +3 | 2 steps above adult baseline; newest step +2 |
| 8 | Experienced Adult | +3 | +6 | 3 steps above adult baseline; newest step +3 |
| 9 | Experienced Adult | +4 | +10 | 4 steps above adult baseline; newest step +4 |
| 10 | Experienced Adult | +5 | +15 | 5 steps above adult baseline; newest step +5 |
| 11 | Veteran Adult | +6 | +21 | 6 steps above adult baseline; newest step +6 |
| 12 | Veteran Adult | +7 | +28 | 7 steps above adult baseline; newest step +7 |
| 13 | Veteran Adult | +8 | +36 | 8 steps above adult baseline; newest step +8 |
| 14 | Veteran Adult | +9 | +45 | 9 steps above adult baseline; newest step +9 |
| 15 | Veteran Adult | +10 | +55 | 10 steps above adult baseline; newest step +10 |
| 16 | Veteran Adult | +11 | +66 | 11 steps above adult baseline; newest step +11 |
| 17 | Veteran Adult | +12 | +78 | 12 steps above adult baseline; newest step +12 |
| 18 | Veteran Adult | +13 | +91 | 13 steps above adult baseline; newest step +13 |
| 19 | Veteran Adult | +14 | +105 | 14 steps above adult baseline; newest step +14 |
| 20 | Veteran Adult | +15 | +120 | 15 steps above adult baseline; newest step +15 |
| 21 | Master Adult | +16 | +136 | 16 steps above adult baseline; newest step +16 |
| 22 | Master Adult | +17 | +153 | 17 steps above adult baseline; newest step +17 |
| 23 | Master Adult | +18 | +171 | 18 steps above adult baseline; newest step +18 |
| 24 | Master Adult | +19 | +190 | 19 steps above adult baseline; newest step +19 |
| 25 | Master Adult | +20 | +210 | 20 steps above adult baseline; newest step +20 |
| 26 | Master Adult | +21 | +231 | 21 steps above adult baseline; newest step +21 |
| 27 | Master Adult | +22 | +253 | 22 steps above adult baseline; newest step +22 |
| 28 | Master Adult | +23 | +276 | 23 steps above adult baseline; newest step +23 |
| 29 | Master Adult | +24 | +300 | 24 steps above adult baseline; newest step +24 |
| 30 | Master Adult | +25 | +325 | 25 steps above adult baseline; newest step +25 |
| 31 | Legendary Adult | +26 | +351 | 26 steps above adult baseline; newest step +26 |
| 32 | Legendary Adult | +27 | +378 | 27 steps above adult baseline; newest step +27 |
| 33 | Legendary Adult | +28 | +406 | 28 steps above adult baseline; newest step +28 |
| 34 | Legendary Adult | +29 | +435 | 29 steps above adult baseline; newest step +29 |
| 35 | Legendary Adult | +30 | +465 | 30 steps above adult baseline; newest step +30 |
| 36 | Legendary Adult | +31 | +496 | 31 steps above adult baseline; newest step +31 |
| 37 | Legendary Adult | +32 | +528 | 32 steps above adult baseline; newest step +32 |
| 38 | Legendary Adult | +33 | +561 | 33 steps above adult baseline; newest step +33 |
| 39 | Legendary Adult | +34 | +595 | 34 steps above adult baseline; newest step +34 |
| 40 | Legendary Adult | +35 | +630 | 35 steps above adult baseline; newest step +35 |
| 41 | Mythic Adult | +36 | +666 | 36 steps above adult baseline; newest step +36 |
| 42 | Mythic Adult | +37 | +703 | 37 steps above adult baseline; newest step +37 |
| 43 | Mythic Adult | +38 | +741 | 38 steps above adult baseline; newest step +38 |
| 44 | Mythic Adult | +39 | +780 | 39 steps above adult baseline; newest step +39 |
| 45 | Mythic Adult | +40 | +820 | 40 steps above adult baseline; newest step +40 |
| 46 | Mythic Adult | +41 | +861 | 41 steps above adult baseline; newest step +41 |
| 47 | Mythic Adult | +42 | +903 | 42 steps above adult baseline; newest step +42 |
| 48 | Mythic Adult | +43 | +946 | 43 steps above adult baseline; newest step +43 |
| 49 | Mythic Adult | +44 | +990 | 44 steps above adult baseline; newest step +44 |
| 50 | Mythic Adult | +45 | +1035 | 45 steps above adult baseline; newest step +45 |

The published NPC scale stops at level 50. If a campaign deliberately needs entities beyond level 50, keep extending the same pattern by adding the next step size.

### NPC Stat Factors

| Priority | Level 5 Base | Target Stat | Use |
| --- | --- | --- | --- |
| Defining | 90 | Base + Significance Score x 2 | Primary combat/casting stat for the NPC's role |
| Supporting | 75 | Base + round(Significance Score x 1.5) | Important secondary stats |
| Ordinary | 60 | Base + Significance Score | Stats that matter but do not define the role |
| Weak | 45 | Base + round(Significance Score / 2) | Intentional weakness; never raise above Ordinary without changing concept |

### NPC Skill Factors

| Priority | Level 5 Base Skill | Target Skill Level | Use |
| --- | --- | --- | --- |
| Signature | 5 | Base + round(Significance Score / 2) | Main weapon, spell list, or defining skill |
| Primary | 4 | Base + round(Significance Score / 3) | Reliable role skills |
| Secondary | 2 | Base + round(Significance Score / 5) | Occasional support skills |
| Incidental | 1 | Base + round(Significance Score / 8) | Background competence |
| Untrained | 0 | 0 | Skills outside the NPC concept |

### NPC Stat Arrays

Assign the level 5 array that best matches the NPC concept, then apply stat factor adjustments, racial stat bonuses, and life-stage age modifiers.

| Array | Strength | Agility | Constitution | Intelligence | Presence | Piety | Best For |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Balanced | 70 | 70 | 70 | 65 | 65 | 60 | General-purpose NPCs |
| Physical | 90 | 75 | 80 | 55 | 55 | 45 | Fighters, Berserkers, guards, laborers |
| Skirmisher | 60 | 95 | 65 | 60 | 75 | 45 | Rogues, archers, scouts |
| Scholar | 45 | 60 | 55 | 95 | 75 | 70 | Wizards, sages, investigators |
| Devout | 60 | 55 | 70 | 65 | 55 | 95 | Clerics, Paladins, zealots |
| Leader | 60 | 65 | 60 | 70 | 95 | 50 | Bards, commanders, negotiators |

### NPC Hits

For a quick NPC, use `Hits = 35 + Level Significance Score x 3 + Constitution bonus x 5`. For a fully built NPC, use the character sheet calculation instead.

### Baseline Level 5 NPCs

The following table gives ready level 5 adult baselines for every race and profession combination allowed by the canonical race/profession matrix in BodyAndBrain.xlsm. At level 5, the level significance score is `0` and the adult age modifier is `0`, so each row applies only the race's stat bonuses to the profession's NPC stat array. Stat cells show `score (bonus)`. Signature skills use the level 5 Signature baseline of `5`.

| Race | Profession | Array | Strength | Agility | Constitution | Intelligence | Presence | Piety | Hits | Signature |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Human | Bard | Leader | 62 (+1) | 66 (+1) | 61 (+1) | 70 (+1) | 95 (+4) | 50 (+1) | 40 | Songs or Persuasion 5 |
| Human | Berserker | Physical | 92 (+3) | 76 (+2) | 81 (+2) | 55 (+1) | 55 (+1) | 45 (+0) | 45 | Primary Melee 5 |
| Human | Cleric | Devout | 62 (+1) | 56 (+1) | 71 (+1) | 65 (+1) | 55 (+1) | 95 (+4) | 40 | Prayer 5 |
| Human | Conjuror | Scholar | 47 (+0) | 61 (+1) | 56 (+1) | 95 (+4) | 75 (+1) | 70 (+1) | 40 | Conjuring 5 |
| Human | Fighter | Physical | 92 (+3) | 76 (+2) | 81 (+2) | 55 (+1) | 55 (+1) | 45 (+0) | 45 | Primary Melee 5 |
| Human | Paladin | Devout | 62 (+1) | 56 (+1) | 71 (+1) | 65 (+1) | 55 (+1) | 95 (+4) | 40 | Prayer or Leadership 5 |
| Human | Ranger | Skirmisher | 62 (+1) | 96 (+4) | 66 (+1) | 60 (+1) | 75 (+1) | 45 (+0) | 40 | Tracking or Primary Missile 5 |
| Human | Rogue | Skirmisher | 62 (+1) | 96 (+4) | 66 (+1) | 60 (+1) | 75 (+1) | 45 (+0) | 40 | Stealing or Hiding 5 |
| Human | Wizard | Scholar | 47 (+0) | 61 (+1) | 56 (+1) | 95 (+4) | 75 (+1) | 70 (+1) | 40 | Wizardry 5 |
| Half-Elf | Bard | Leader | 61 (+1) | 67 (+1) | 61 (+1) | 71 (+1) | 96 (+4) | 48 (+0) | 40 | Songs or Persuasion 5 |
| Half-Elf | Conjuror | Scholar | 46 (+0) | 62 (+1) | 56 (+1) | 96 (+4) | 76 (+2) | 68 (+1) | 40 | Conjuring 5 |
| Half-Elf | Fighter | Physical | 91 (+3) | 77 (+2) | 81 (+2) | 56 (+1) | 56 (+1) | 43 (+0) | 45 | Primary Melee 5 |
| Half-Elf | Ranger | Skirmisher | 61 (+1) | 97 (+4) | 66 (+1) | 61 (+1) | 76 (+2) | 43 (+0) | 40 | Tracking or Primary Missile 5 |
| Half-Elf | Rogue | Skirmisher | 61 (+1) | 97 (+4) | 66 (+1) | 61 (+1) | 76 (+2) | 43 (+0) | 40 | Stealing or Hiding 5 |
| Half-Elf | Wizard | Scholar | 46 (+0) | 62 (+1) | 56 (+1) | 96 (+4) | 76 (+2) | 68 (+1) | 40 | Wizardry 5 |
| Elf | Bard | Leader | 60 (+1) | 68 (+1) | 60 (+1) | 72 (+1) | 97 (+4) | 47 (+0) | 40 | Songs or Persuasion 5 |
| Elf | Conjuror | Scholar | 45 (+0) | 63 (+1) | 55 (+1) | 97 (+4) | 77 (+2) | 67 (+1) | 40 | Conjuring 5 |
| Elf | Ranger | Skirmisher | 60 (+1) | 98 (+4) | 65 (+1) | 62 (+1) | 77 (+2) | 42 (+0) | 40 | Tracking or Primary Missile 5 |
| Elf | Rogue | Skirmisher | 60 (+1) | 98 (+4) | 65 (+1) | 62 (+1) | 77 (+2) | 42 (+0) | 40 | Stealing or Hiding 5 |
| Elf | Wizard | Scholar | 45 (+0) | 63 (+1) | 55 (+1) | 97 (+4) | 77 (+2) | 67 (+1) | 40 | Wizardry 5 |
| Dwarf | Berserker | Physical | 92 (+3) | 74 (+1) | 82 (+2) | 55 (+1) | 55 (+1) | 46 (+0) | 45 | Primary Melee 5 |
| Dwarf | Cleric | Devout | 62 (+1) | 54 (+1) | 72 (+1) | 65 (+1) | 55 (+1) | 96 (+4) | 40 | Prayer 5 |
| Dwarf | Conjuror | Scholar | 47 (+0) | 59 (+1) | 57 (+1) | 95 (+4) | 75 (+1) | 71 (+1) | 40 | Conjuring 5 |
| Dwarf | Fighter | Physical | 92 (+3) | 74 (+1) | 82 (+2) | 55 (+1) | 55 (+1) | 46 (+0) | 45 | Primary Melee 5 |
| Dwarf | Paladin | Devout | 62 (+1) | 54 (+1) | 72 (+1) | 65 (+1) | 55 (+1) | 96 (+4) | 40 | Prayer or Leadership 5 |
| Dwarf | Wizard | Scholar | 47 (+0) | 59 (+1) | 57 (+1) | 95 (+4) | 75 (+1) | 71 (+1) | 40 | Wizardry 5 |
| Halfling | Bard | Leader | 59 (+1) | 67 (+1) | 60 (+1) | 71 (+1) | 97 (+4) | 50 (+1) | 40 | Songs or Persuasion 5 |
| Halfling | Cleric | Devout | 59 (+1) | 57 (+1) | 70 (+1) | 66 (+1) | 57 (+1) | 95 (+4) | 40 | Prayer 5 |
| Halfling | Conjuror | Scholar | 44 (+0) | 62 (+1) | 55 (+1) | 96 (+4) | 77 (+2) | 70 (+1) | 40 | Conjuring 5 |
| Halfling | Ranger | Skirmisher | 59 (+1) | 97 (+4) | 65 (+1) | 61 (+1) | 77 (+2) | 45 (+0) | 40 | Tracking or Primary Missile 5 |
| Halfling | Rogue | Skirmisher | 59 (+1) | 97 (+4) | 65 (+1) | 61 (+1) | 77 (+2) | 45 (+0) | 40 | Stealing or Hiding 5 |
| Halfling | Wizard | Scholar | 44 (+0) | 62 (+1) | 55 (+1) | 96 (+4) | 77 (+2) | 70 (+1) | 40 | Wizardry 5 |
| Reptilian | Berserker | Physical | 92 (+3) | 74 (+1) | 81 (+2) | 55 (+1) | 55 (+1) | 47 (+0) | 45 | Primary Melee 5 |
| Reptilian | Cleric | Devout | 62 (+1) | 54 (+1) | 71 (+1) | 65 (+1) | 55 (+1) | 97 (+4) | 40 | Prayer 5 |
| Reptilian | Conjuror | Scholar | 47 (+0) | 59 (+1) | 56 (+1) | 95 (+4) | 75 (+1) | 72 (+1) | 40 | Conjuring 5 |
| Reptilian | Fighter | Physical | 92 (+3) | 74 (+1) | 81 (+2) | 55 (+1) | 55 (+1) | 47 (+0) | 45 | Primary Melee 5 |
| Reptilian | Paladin | Devout | 62 (+1) | 54 (+1) | 71 (+1) | 65 (+1) | 55 (+1) | 97 (+4) | 40 | Prayer or Leadership 5 |
| Reptilian | Wizard | Scholar | 47 (+0) | 59 (+1) | 56 (+1) | 95 (+4) | 75 (+1) | 72 (+1) | 40 | Wizardry 5 |
| Orc | Fighter | Physical | 93 (+3) | 75 (+1) | 82 (+2) | 52 (+1) | 54 (+1) | 45 (+0) | 45 | Primary Melee 5 |
| Orc | Berserker | Physical | 93 (+3) | 75 (+1) | 82 (+2) | 52 (+1) | 54 (+1) | 45 (+0) | 45 | Primary Melee 5 |
| Orc | Cleric | Devout | 63 (+1) | 55 (+1) | 72 (+1) | 62 (+1) | 54 (+1) | 95 (+4) | 40 | Prayer 5 |
| Feline | Bard | Leader | 59 (+1) | 68 (+1) | 60 (+1) | 70 (+1) | 98 (+4) | 49 (+0) | 40 | Songs or Persuasion 5 |
| Feline | Conjuror | Scholar | 44 (+0) | 63 (+1) | 55 (+1) | 95 (+4) | 78 (+2) | 69 (+1) | 40 | Conjuring 5 |
| Feline | Ranger | Skirmisher | 59 (+1) | 98 (+4) | 65 (+1) | 60 (+1) | 78 (+2) | 44 (+0) | 40 | Tracking or Primary Missile 5 |
| Feline | Rogue | Skirmisher | 59 (+1) | 98 (+4) | 65 (+1) | 60 (+1) | 78 (+2) | 44 (+0) | 40 | Stealing or Hiding 5 |
| Feline | Wizard | Scholar | 44 (+0) | 63 (+1) | 55 (+1) | 95 (+4) | 78 (+2) | 69 (+1) | 40 | Wizardry 5 |

### NPC Scaling Guidance By Profession

These tables show how the NPC scaling curve tends to affect each valid race for each profession. The level 1 and level 50 checkpoints include the level significance score, racial stat bonuses, and age modifiers. Use them as guidance for quick NPCs; fully built NPCs still use the complete character rules.

#### Bard

Array: Leader. Scaling emphasis: Presence defines scaling; Agility, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Presence 95 (+4); Hits 40; neutral Presence; +1 Constitution improves hit scaling | Level 1: Presence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Presence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Presence 96 (+4); Hits 40; racial +1 reinforces Presence; +1 Constitution improves hit scaling | Level 1: Presence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Presence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Elf | Presence 97 (+4); Hits 40; racial +2 reinforces Presence; neutral hits | Level 1: Presence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Presence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Presence 97 (+4); Hits 40; racial +2 reinforces Presence; neutral hits | Level 1: Presence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Presence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Feline | Presence 98 (+4); Hits 40; racial +3 reinforces Presence; neutral hits | Level 1: Presence 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Presence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Berserker

Array: Physical. Scaling emphasis: Strength defines scaling; Agility, Constitution support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Orc | Strength 93 (+3); Hits 45; racial +3 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 63 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Cleric

Array: Devout. Scaling emphasis: Piety defines scaling; Constitution, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Piety 95 (+4); Hits 40; neutral Piety; +1 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Piety 96 (+4); Hits 40; racial +1 reinforces Piety; +2 Constitution improves hit scaling | Level 1: Piety 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Piety 95 (+4); Hits 40; neutral Piety; neutral hits | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Piety 97 (+4); Hits 40; racial +2 reinforces Piety; +1 Constitution improves hit scaling | Level 1: Piety 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Orc | Piety 95 (+4); Hits 40; neutral Piety; +2 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Conjuror

Array: Scholar. Scaling emphasis: Intelligence defines scaling; Presence, Piety support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Elf | Intelligence 97 (+4); Hits 40; racial +2 reinforces Intelligence; neutral hits | Level 1: Intelligence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Intelligence 95 (+4); Hits 40; neutral Intelligence; +2 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; neutral hits | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Feline | Intelligence 95 (+4); Hits 40; neutral Intelligence; neutral hits | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Fighter

Array: Physical. Scaling emphasis: Strength defines scaling; Agility, Constitution support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Strength 91 (+3); Hits 45; racial +1 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 61 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Orc | Strength 93 (+3); Hits 45; racial +3 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 63 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Strength 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Paladin

Array: Devout. Scaling emphasis: Piety defines scaling; Constitution, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Piety 95 (+4); Hits 40; neutral Piety; +1 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Piety 96 (+4); Hits 40; racial +1 reinforces Piety; +2 Constitution improves hit scaling | Level 1: Piety 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Piety 97 (+4); Hits 40; racial +2 reinforces Piety; +1 Constitution improves hit scaling | Level 1: Piety 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Piety 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Ranger

Array: Skirmisher. Scaling emphasis: Agility defines scaling; Presence supports it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Agility 96 (+4); Hits 40; racial +1 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Elf | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; neutral hits | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Feline | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Rogue

Array: Skirmisher. Scaling emphasis: Agility defines scaling; Presence supports it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Agility 96 (+4); Hits 40; racial +1 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Elf | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; neutral hits | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Feline | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Agility 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

#### Wizard

Array: Scholar. Scaling emphasis: Intelligence defines scaling; Presence, Piety support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Half-Elf | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Elf | Intelligence 97 (+4); Hits 40; racial +2 reinforces Intelligence; neutral hits | Level 1: Intelligence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Dwarf | Intelligence 95 (+4); Hits 40; neutral Intelligence; +2 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Halfling | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; neutral hits | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Reptilian | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |
| Feline | Intelligence 95 (+4); Hits 40; neutral Intelligence; neutral hits | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 50: Intelligence 100 (+10), Hits 3190. Mythic levels keep the experienced-adult age modifier and usually cap defining stats at 100. |

### Traditional Monster Level 5 Baselines

The following quick-play baselines treat traditional monsters as NPC archetypes. Each monster receives two logical profession templates. These are best-fit GM tools rather than player race/profession permissions: start from the profession's level 5 NPC stat array, apply the monster profile modifier, clamp stats to 1 through 100, then calculate hits normally. Stat cells show `score (bonus)`.

Exceptional monsters (`Lich`, `Demon`, `Dragon`, and `Vampire`) have one overdriven stat tied to their physical or mental exceptionalism. When a skill is governed by that overdriven stat, increase the effect of the skill by 50% after the ordinary skill result is determined. This changes the result's effect, not the roll, stat score, skill level, or hit total.

| Monster | Profession | Role | Strength | Agility | Constitution | Intelligence | Presence | Piety | Overdriven Stat | Overdrive Effect | Hits | Signature |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Goblin | Rogue | ambusher | 52 (+1) | 98 (+4) | 61 (+1) | 60 (+1) | 73 (+1) | 43 (+0) | - | - | 40 | Stealing or Hiding 5 |
| Goblin | Ranger | skirmisher | 52 (+1) | 98 (+4) | 61 (+1) | 60 (+1) | 73 (+1) | 43 (+0) | - | - | 40 | Tracking or Primary Missile 5 |
| Hobgoblin | Fighter | soldier | 92 (+3) | 76 (+2) | 82 (+2) | 55 (+1) | 57 (+1) | 45 (+0) | - | - | 45 | Primary Melee 5 |
| Hobgoblin | Paladin | champion | 62 (+1) | 56 (+1) | 72 (+1) | 65 (+1) | 57 (+1) | 95 (+4) | - | - | 40 | Prayer or Leadership 5 |
| Kobold | Rogue | trapper | 50 (+1) | 98 (+4) | 60 (+1) | 62 (+1) | 73 (+1) | 45 (+0) | - | - | 40 | Stealing or Hiding 5 |
| Kobold | Conjuror | hex worker | 35 (+0) | 63 (+1) | 50 (+1) | 97 (+4) | 73 (+1) | 70 (+1) | - | - | 40 | Conjuring 5 |
| Orc | Berserker | raider | 93 (+3) | 75 (+1) | 82 (+2) | 52 (+1) | 54 (+1) | 45 (+0) | - | - | 45 | Primary Melee 5 |
| Orc | Fighter | warrior | 93 (+3) | 75 (+1) | 82 (+2) | 52 (+1) | 54 (+1) | 45 (+0) | - | - | 45 | Primary Melee 5 |
| Ogre | Berserker | brute | 100 (+10) | 67 (+1) | 90 (+3) | 47 (+0) | 51 (+1) | 41 (+0) | - | - | 50 | Primary Melee 5 |
| Ogre | Fighter | club guard | 100 (+10) | 67 (+1) | 90 (+3) | 47 (+0) | 51 (+1) | 41 (+0) | - | - | 50 | Primary Melee 5 |
| Troll | Berserker | regenerator | 100 (+10) | 72 (+1) | 94 (+3) | 49 (+0) | 51 (+1) | 43 (+0) | - | - | 50 | Primary Melee 5 |
| Troll | Ranger | stalker | 70 (+1) | 92 (+3) | 79 (+2) | 54 (+1) | 71 (+1) | 43 (+0) | - | - | 45 | Tracking or Primary Missile 5 |
| Skeleton | Fighter | bone guard | 90 (+3) | 75 (+1) | 72 (+1) | 45 (+0) | 47 (+0) | 35 (+0) | - | - | 40 | Primary Melee 5 |
| Skeleton | Ranger | dead archer | 60 (+1) | 95 (+4) | 57 (+1) | 50 (+1) | 67 (+1) | 35 (+0) | - | - | 40 | Tracking or Primary Missile 5 |
| Zombie | Fighter | shambler | 94 (+3) | 63 (+1) | 92 (+3) | 40 (+0) | 43 (+0) | 35 (+0) | - | - | 50 | Primary Melee 5 |
| Zombie | Berserker | relentless dead | 94 (+3) | 63 (+1) | 92 (+3) | 40 (+0) | 43 (+0) | 35 (+0) | - | - | 50 | Primary Melee 5 |
| Ghoul | Rogue | grave ambusher | 62 (+1) | 98 (+4) | 67 (+1) | 56 (+1) | 73 (+1) | 37 (+0) | - | - | 40 | Stealing or Hiding 5 |
| Ghoul | Berserker | feeding frenzy | 92 (+3) | 78 (+2) | 82 (+2) | 51 (+1) | 53 (+1) | 37 (+0) | - | - | 45 | Primary Melee 5 |
| Vampire | Rogue | night stalker | 64 (+1) | 98 (+4) | 67 (+1) | 64 (+1) | 83 (+2) | 37 (+0) | Agility | Governed skill effect x1.5 | 40 | Stealing or Hiding 5 |
| Vampire | Conjuror | blood sorcerer | 49 (+0) | 63 (+1) | 57 (+1) | 99 (+7) | 83 (+2) | 62 (+1) | Intelligence | Governed skill effect x1.5 | 40 | Conjuring 5 |
| Werewolf | Berserker | frenzied beast | 98 (+4) | 78 (+2) | 86 (+2) | 53 (+1) | 55 (+1) | 41 (+0) | - | - | 45 | Primary Melee 5 |
| Werewolf | Ranger | moon hunter | 68 (+1) | 98 (+4) | 71 (+1) | 58 (+1) | 75 (+1) | 41 (+0) | - | - | 40 | Tracking or Primary Missile 5 |
| Giant | Fighter | club warrior | 100 (+10) | 67 (+1) | 92 (+3) | 51 (+1) | 57 (+1) | 45 (+0) | - | - | 50 | Primary Melee 5 |
| Giant | Berserker | stone thrower | 100 (+10) | 67 (+1) | 92 (+3) | 51 (+1) | 57 (+1) | 45 (+0) | - | - | 50 | Primary Melee 5 |
| Minotaur | Fighter | maze guard | 100 (+10) | 75 (+1) | 88 (+2) | 53 (+1) | 55 (+1) | 43 (+0) | - | - | 45 | Primary Melee 5 |
| Minotaur | Berserker | charger | 100 (+10) | 75 (+1) | 88 (+2) | 53 (+1) | 55 (+1) | 43 (+0) | - | - | 45 | Primary Melee 5 |
| Harpy | Bard | song lure | 56 (+1) | 68 (+1) | 58 (+1) | 70 (+1) | 100 (+10) | 46 (+0) | - | - | 40 | Songs or Persuasion 5 |
| Harpy | Rogue | aerial thief | 56 (+1) | 98 (+4) | 63 (+1) | 60 (+1) | 83 (+2) | 41 (+0) | - | - | 40 | Stealing or Hiding 5 |
| Gargoyle | Fighter | stone sentinel | 96 (+4) | 75 (+1) | 90 (+3) | 51 (+1) | 53 (+1) | 41 (+0) | - | - | 50 | Primary Melee 5 |
| Gargoyle | Rogue | statue ambusher | 66 (+1) | 95 (+4) | 75 (+1) | 56 (+1) | 73 (+1) | 41 (+0) | - | - | 40 | Stealing or Hiding 5 |
| Dragon | Fighter | ancient terror | 100 (+10) | 79 (+2) | 92 (+3) | 63 (+1) | 65 (+1) | 45 (+0) | Strength | Governed skill effect x1.5 | 50 | Primary Melee 5 |
| Dragon | Conjuror | breath caster | 60 (+1) | 64 (+1) | 67 (+1) | 100 (+10) | 85 (+2) | 70 (+1) | Intelligence | Governed skill effect x1.5 | 40 | Conjuring 5 |
| Lich | Wizard | undead archmage | 37 (+0) | 56 (+1) | 49 (+0) | 100 (+10) | 83 (+2) | 60 (+1) | Intelligence | Governed skill effect x1.5 | 35 | Wizardry 5 |
| Lich | Conjuror | death summoner | 37 (+0) | 56 (+1) | 49 (+0) | 100 (+10) | 83 (+2) | 60 (+1) | Intelligence | Governed skill effect x1.5 | 35 | Conjuring 5 |
| Demon | Berserker | fiendish brute | 100 (+10) | 79 (+2) | 88 (+2) | 59 (+1) | 63 (+1) | 33 (+0) | Strength | Governed skill effect x1.5 | 45 | Primary Melee 5 |
| Demon | Conjuror | hell caster | 55 (+1) | 64 (+1) | 63 (+1) | 99 (+7) | 83 (+2) | 58 (+1) | Intelligence | Governed skill effect x1.5 | 40 | Conjuring 5 |

### NPC Stat Block

A complete NPC only needs the fields that can matter at the table.

| Field | Use |
| --- | --- |
| Name and Role | What the NPC is in the scene |
| Level / Tier | Use the tier table, then adjust if the party needs a weaker or stronger encounter |
| Race / Profession / Apprenticeship | Use canonical race, profession, and apprenticeship rules when the NPC is classed |
| Stats and Bonuses | Assign one stat array, then add racial bonuses, age modifiers, and stat bonuses |
| Hits | Use the tier hit guideline or the character sheet calculation if the NPC is fully built |
| Primary Attack or Spell | Record one attack bonus, damage, critical type, or spell list skill |
| Defenses | Record armor profile, armor skill, resistance bonuses, and notable conditions |
| Tactics | One sentence describing how the NPC behaves before surrendering, fleeing, or escalating |

### NPC Behavior

Give each NPC a goal, a limit, and a retreat condition. A guard may want to delay intruders, avoid death, and flee when reduced below half hits. A cult leader may want to finish a ritual, sacrifice followers first, and surrender only if their patron is disproven. This keeps NPCs from fighting to the death unless the fiction demands it.
