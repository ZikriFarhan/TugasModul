import method

print ("Muhammad Abinaya Isaqofi\t\t\t21120119130039")
print ("Muhammad Dzikrullah Farhan\t\t\t21120119140134")
print ("Kelompok 50\nShift 2\n\t\t\t\tTUGAS")

demam=0
asma=0
uhuk=0
ulang = 1
covid = 0
x = method.output(covid)

def return_func(demam, asma, uhuk):
    covid=float((demam+asma+uhuk)/3)
    return

while (ulang == 1):
    print ("\n\n\n======================COVID-19 RAPID TEST======================\n\n\n")
    sumuk=str(input("Apakah Anda mengalami demam?\t\t\t(iya/tidak)\n"))
    if sumuk == "iya":
        suhu=float(input("\nBerapa suhu tubuh Anda?\n"))
        if suhu >37.5:
            demam=1
        else:
            demam=0
    elif sumuk == "tidak":
        demam=0

    gangfas=str(input("\nApakah Anda mengalami gangguan nafas?\t\t(iya/tidak)\n"))
    if gangfas == "iya":
        nafas=str(input("\nApakah Anda mengalami sesak nafas?\t\t(iya/tidak)\n"))
        if nafas == "iya":
            asma=1
        elif nafas == "tidak":
            asma=0
    elif gangfas == "tidak":
        asma=0

    batuk=str(input("\nApakah Anda mengalami batuk?\t\t\t(iya/tidak)\n"))
    if batuk == "iya":
        kering=str(input("\nApakah batuk yang diderita adalah batuk kering?\t(iya/tidak)\n"))
        if kering == "iya":
            uhuk=1
        elif kering == "tidak":
            uhuk=0
    elif batuk == "tidak":
        uhuk=0

    return_func(demam, asma, uhuk)
    x.hasil(covid)

    akhir=str(input("\n\nApakah Anda ingin mencoba lagi?\t\t(iya/tidak)\n"))
    if akhir == "iya":
        ulang = 0
    elif akhir == "tidak":
        ulang = 1

    ulang+=1

print("\n\t\tJaga Kesehatan\n\n")
