## Non-Player Characters

_____

NPCs use the same race, profession, skill, resistance, attack, spell, armor, and maneuver rules as player characters. For important recurring characters, build the NPC as a full character. For a one-scene opponent or ally, use the quick generator below.

### NPC Generation

The quick generator starts from a level 5 adult base NPC. Level changes use an inverted bell curve: changes near level 5 are small, while changes farther from level 5 become increasingly significant.

1. Choose the NPC's target level.
2. Calculate `Level Offset = Target Level - 5`.
3. Convert that offset into a signed `Level Significance Score`: `sign(Level Offset) x triangular(abs(Level Offset))`, where `triangular(n) = n x (n + 1) / 2`.
4. Choose a race, profession, apprenticeship, and role concept if the NPC is classed. For an unclassed creature, choose the closest attack profile, armor profile, and resistance profile.
5. Assign a level 5 stat array from [NPC Stat Arrays](#npc-stat-arrays), then apply the stat factor table, racial stat bonuses, and age modifiers from [Age Influence On Stats](#age-influence-on-stats). Clamp final stats to the normal character range of 1 to 100.
6. Assign level 5 skill baselines from the skill factor table, then apply the same `Level Significance Score`. Clamp final skill levels to the normal skill range of 0 to 10 unless the campaign deliberately allows epic skill levels.
7. Calculate bonuses normally from the resulting stats and skill levels.
8. Give the NPC one tactic, one goal, and one retreat or escalation condition.

### NPC Level Significance

The curve below makes level changes close to 5 modest, but makes each additional step away from level 5 more important than the previous step.

| Target Level | Life Stage | Level Offset | Level Significance Score | Step Meaning |
| --- | --- | --- | --- | --- |
| 1 | Apprentice / Adolescent | -4 | -10 | Four steps below adult baseline: -1, -2, -3, -4 |
| 2 | Young Adult | -3 | -6 | Three steps below adult baseline: -1, -2, -3 |
| 3 | Young Adult | -2 | -3 | Two steps below adult baseline: -1, -2 |
| 4 | Young Adult | -1 | -1 | One step below adult baseline |
| 5 | Adult | 0 | 0 | Base adult NPC |
| 6 | Adult | +1 | +1 | One step above adult baseline |
| 7 | Adult | +2 | +3 | Two steps above adult baseline: +1, +2 |
| 8 | Experienced Adult | +3 | +6 | Three steps above adult baseline: +1, +2, +3 |
| 9 | Experienced Adult | +4 | +10 | Four steps above adult baseline: +1, +2, +3, +4 |
| 10 | Experienced Adult | +5 | +15 | Five steps above adult baseline: +1, +2, +3, +4, +5 |

For target levels beyond 10, keep extending the same pattern by adding the next step size. For example, level 11 has score +21 because level 10 is +15 and the next step is +6.

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

These tables show how the NPC scaling curve tends to affect each valid race for each profession. The level 1 and level 10 checkpoints include the level significance score, racial stat bonuses, and age modifiers. Use them as guidance for quick NPCs; fully built NPCs still use the complete character rules.

#### Bard

Array: Leader. Scaling emphasis: Presence defines scaling; Agility, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Presence 95 (+4); Hits 40; neutral Presence; +1 Constitution improves hit scaling | Level 1: Presence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Presence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Presence 96 (+4); Hits 40; racial +1 reinforces Presence; +1 Constitution improves hit scaling | Level 1: Presence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Presence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Elf | Presence 97 (+4); Hits 40; racial +2 reinforces Presence; neutral hits | Level 1: Presence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Presence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Presence 97 (+4); Hits 40; racial +2 reinforces Presence; neutral hits | Level 1: Presence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Presence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Feline | Presence 98 (+4); Hits 40; racial +3 reinforces Presence; neutral hits | Level 1: Presence 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Presence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Berserker

Array: Physical. Scaling emphasis: Strength defines scaling; Agility, Constitution support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 115. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 130. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 115. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Orc | Strength 93 (+3); Hits 45; racial +3 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 63 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 130. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Cleric

Array: Devout. Scaling emphasis: Piety defines scaling; Constitution, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Piety 95 (+4); Hits 40; neutral Piety; +1 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Piety 96 (+4); Hits 40; racial +1 reinforces Piety; +2 Constitution improves hit scaling | Level 1: Piety 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 95. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Piety 95 (+4); Hits 40; neutral Piety; neutral hits | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Piety 97 (+4); Hits 40; racial +2 reinforces Piety; +1 Constitution improves hit scaling | Level 1: Piety 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Orc | Piety 95 (+4); Hits 40; neutral Piety; +2 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 95. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Conjuror

Array: Scholar. Scaling emphasis: Intelligence defines scaling; Presence, Piety support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Elf | Intelligence 97 (+4); Hits 40; racial +2 reinforces Intelligence; neutral hits | Level 1: Intelligence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Intelligence 95 (+4); Hits 40; neutral Intelligence; +2 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; neutral hits | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Feline | Intelligence 95 (+4); Hits 40; neutral Intelligence; neutral hits | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Fighter

Array: Physical. Scaling emphasis: Strength defines scaling; Agility, Constitution support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 115. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Strength 91 (+3); Hits 45; racial +1 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 61 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 115. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 130. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Strength 92 (+3); Hits 45; racial +2 reinforces Strength; +1 Constitution improves hit scaling | Level 1: Strength 62 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 115. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Orc | Strength 93 (+3); Hits 45; racial +3 reinforces Strength; +2 Constitution improves hit scaling | Level 1: Strength 63 (+1), Hits 10. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Strength 100 (+10), Hits 130. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Paladin

Array: Devout. Scaling emphasis: Piety defines scaling; Constitution, Intelligence support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Piety 95 (+4); Hits 40; neutral Piety; +1 Constitution improves hit scaling | Level 1: Piety 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Piety 96 (+4); Hits 40; racial +1 reinforces Piety; +2 Constitution improves hit scaling | Level 1: Piety 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 95. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Piety 97 (+4); Hits 40; racial +2 reinforces Piety; +1 Constitution improves hit scaling | Level 1: Piety 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Piety 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Ranger

Array: Skirmisher. Scaling emphasis: Agility defines scaling; Presence supports it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Agility 96 (+4); Hits 40; racial +1 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Elf | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; neutral hits | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Feline | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Rogue

Array: Skirmisher. Scaling emphasis: Agility defines scaling; Presence supports it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Agility 96 (+4); Hits 40; racial +1 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; +1 Constitution improves hit scaling | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 90. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Elf | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Agility 97 (+4); Hits 40; racial +2 reinforces Agility; neutral hits | Level 1: Agility 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Feline | Agility 98 (+4); Hits 40; racial +3 reinforces Agility; neutral hits | Level 1: Agility 68 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Agility 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |

#### Wizard

Array: Scholar. Scaling emphasis: Intelligence defines scaling; Presence, Piety support it.

| Race | Level 5 Anchor | Scaling Down | Scaling Up |
| --- | --- | --- | --- |
| Human | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Half-Elf | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Elf | Intelligence 97 (+4); Hits 40; racial +2 reinforces Intelligence; neutral hits | Level 1: Intelligence 67 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Dwarf | Intelligence 95 (+4); Hits 40; neutral Intelligence; +2 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Halfling | Intelligence 96 (+4); Hits 40; racial +1 reinforces Intelligence; neutral hits | Level 1: Intelligence 66 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Reptilian | Intelligence 95 (+4); Hits 40; neutral Intelligence; +1 Constitution improves hit scaling | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |
| Feline | Intelligence 95 (+4); Hits 40; neutral Intelligence; neutral hits | Level 1: Intelligence 65 (+1), Hits 5. Adolescent penalties make both Body and Brain immature; young-adult levels recover Body first. | Level 10: Intelligence 100 (+10), Hits 85. Experienced levels add Brain and reduce Body after the significance score is applied. |

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
