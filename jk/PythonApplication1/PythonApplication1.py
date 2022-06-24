
import pandas as pd
from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import train_test_split 
#from sklearn import metrics as accuracy_score
#import numpy as np
from sklearn.metrics import classification_report

#col_names = ['A', 'C', 'B1', 'classif']
# load dataset
data = pd.read_csv("/content/newDataset.csv")
df=pd.DataFrame(data, columns=['disease','abdominal_pain','acidity','acute_liver_failure','altered_sensorium'] ) 
df
#feature_cols =['disease','abdominal_pain','acidity','acute_liver_failure','altered_sensorium']
#feature_cols =['abdominal_pain','acidity','acute_liver_failure','altered_sensorium']
#X=data[feature_cols]  # Features

y =data.disease  # Target variable
x=data.iloc[:,1:]
X_train, X_test, y_train, y_test = train_test_split(x, y,test_size=0.3, random_state=0)
clf = DecisionTreeClassifier().fit(X_train, y_train)

# Train Decision Tree Classifer
#clf = clf.
print (X_train)
print(y_train)
print(X_test)
#Predict the response for test dataset
prediction_fin = clf.predict(X_test)

print("*****************************")
print("decision tree accuracy")
print("Accuracy:",classification_report(y_test, prediction_fin))import pandas as pd
from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import train_test_split 
#from sklearn import metrics as accuracy_score
#import numpy as np
from sklearn.metrics import classification_report

#col_names = ['A', 'C', 'B1', 'classif']
# load dataset
data = pd.read_csv("/content/newDataset.csv")
df=pd.DataFrame(data, columns=['disease','abdominal_pain','acidity','acute_liver_failure','altered_sensorium'] ) 
df
#feature_cols =['disease','abdominal_pain','acidity','acute_liver_failure','altered_sensorium']
#feature_cols =['abdominal_pain','acidity','acute_liver_failure','altered_sensorium']
#X=data[feature_cols]  # Features

y =data.disease  # Target variable
x=data.iloc[:,1:]
X_train, X_test, y_train, y_test = train_test_split(x, y,test_size=0.3, random_state=0)
clf = DecisionTreeClassifier().fit(X_train, y_train)

# Train Decision Tree Classifer
#clf = clf.
print (X_train)
print(y_train)
print(X_test)
#Predict the response for test dataset
prediction_fin = clf.predict(X_test)

print("*****************************")
print("decision tree accuracy")
print("Accuracy:",classification_report(y_test, prediction_fin))