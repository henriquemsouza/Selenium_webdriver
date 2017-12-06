#!/usr/bin/env python

import unittest
from selenium import webdriver


class TestGoogleHomepage(unittest.TestCase):

    def setUp(self):
        self.browser = webdriver.Firefox()

    def testTitle(self):
        self.browser.get('https://www.google.com.br')
        self.assertIn('Google', self.browser.title)

    def tearDown(self):
        self.browser.quit()


if __name__ == '__main__':
    unittest.main(verbosity=2)
