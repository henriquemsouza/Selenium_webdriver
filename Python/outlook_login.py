from selenium import webdriver
from selenium.webdriver.common.keys import Keys

driver = webdriver.Firefox(executable_path=r'C:\Users\souza\Documents\geckodriver.exe')
user = "m_s@hotmail.com"
pwd = ""


driver.get("https://login.live.com/")
assert "Microsoft" in driver.title


elem = driver.find_element_by_class_name('phholder')
elem.send_keys(user)
driver.find_element_by_id("idSIButton9").click()

#not work
#driver.find_element_by_class_name('phholder').click()
#elem = driver.find_element_by_class_name('phholder')
#elem.send_keys(pwd)
#driver.find_element_by_id('idSIButton9').click()
