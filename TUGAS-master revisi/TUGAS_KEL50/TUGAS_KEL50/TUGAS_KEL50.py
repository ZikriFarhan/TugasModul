print ("Muhammad Abinaya Isaqofi\t21120119130039")
print ("Muhammad Dzikrullah Farhan\t21120119140134")
print ("Kelompok 50\nShift 2\nTUGAS\n\n")
print ("\t\t\tCOVID-19 RAPID TEST\n")

demam=0
asma=0
uhuk=0

sumuk=str(input("Apakah Anda mengalami demam?\t\t\t(iya/tidak)\n"))
while True:
    sumuk = str(input("Apakah Anda mengalami demam?\t\t\t(iya/tidak)\n"))
    if sumuk == "iya":
        suhu=float(input("Berapa suhu tubuh Anda?\n"))
        if suhu >37.5:
            demam=1
        else:
            demam=0
        break
    elif sumuk == "tidak":
        demam=0
        break
    else: continue

gangfas=str(input("Apakah Anda mengalami gangguan nafas?\t\t(iya/tidak)\n"))
while True:
    gangfas = str(input("Apakah Anda mengalami gangguan nafas?\t\t(iya/tidak)\n"))
    if gangfas == "iya":
        nafas=str(input("Apakah Anda mengalami sesak nafas?\t\t(iya/tidak)\n"))
        if nafas == "iya":
            asma=1
        elif nafas == "tidak":
            asma=0
            break
    elif gangfas == "tidak":
        asma=0
        break
    else:continue

batuk=str(input("Apakah Anda mengalami batuk?\t\t\t(oya/tidak)\n"))
while True:
    batuk = str(input("Apakah Anda mengalami batuk?\t\t\t(oya/tidak)\n"))
    if batuk == "iya":
        kering=str(input("Apakah batuk yang diderita adalah batuk kering?\t(iya/tidak)\n"))
        if kering == "iya":
            uhuk=1
        elif kering == "tidak":
            uhuk=0
            break
    elif batuk == "tidak":
        uhuk=0
        break
    else:continue

covid=float((demam+asma+uhuk)/3)

print ("\n")

if covid == 1:
    print("Anda mengalami gejala yang sama dengan gejala COVID-19")
    print("Kemungkinan besar Anda mengalami COVID-19")
    print("Periksakan diri Anda ke RS rujukan terdekat")
elif covid < 0.8:
     print("Anda mengalami gejala yang mirip dengan gejala COVID-19")
     print("Kemungkinan kecil Anda mengalami COVID-19")
     print("Lakukan karantina mandiri di rumah")
elif covid < 0.5:
     print("Anda tidak mengalami gejala COVID-19")
     print("Kemungkinan Anda tidak mengalami COVID-19")
     print("Lakukan Social Distancing di lingkungan")

print("\n\t\tJaga Kesehatan\n\n")
