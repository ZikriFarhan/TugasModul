class output:
    def __init__(self, covid):
        self.covid=covid

    def hasil(self, covid):
         if covid == 1:
                 print("\n\nAnda mengalami gejala yang sama dengan gejala COVID-19")
                 print("Kemungkinan besar Anda mengalami COVID-19")
                 print("Periksakan diri Anda ke RS rujukan terdekat")
                 return
         elif covid < 0.8:
                 print("\n\nAnda mengalami gejala yang mirip dengan gejala COVID-19")
                 print("Kemungkinan kecil Anda mengalami COVID-19")
                 print("Lakukan karantina mandiri di rumah")
                 return
         elif covid < 0.5:
                 print("\n\nAnda tidak mengalami gejala COVID-19")
                 print("Kemungkinan Anda tidak mengalami COVID-19")
                 print("Lakukan Social Distancing di lingkungan")
                 return

