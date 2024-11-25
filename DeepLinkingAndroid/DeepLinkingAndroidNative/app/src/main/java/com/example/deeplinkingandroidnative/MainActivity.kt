package com.example.deeplinkingandroidnative

import android.content.Intent
import android.net.Uri
import android.os.Bundle
import android.util.Log
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.browser.customtabs.CustomTabsIntent
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.safeDrawingPadding
import androidx.compose.material3.Button
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.deeplinkingandroidnative.ui.theme.DeepLinkingAndroidNativeTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        print("onCreate: ")
        println(intent.getStringExtra("data"))

        enableEdgeToEdge()
        setContent {
            DeepLinkingAndroidNativeTheme {
                Column(
                    modifier = Modifier
                        .safeDrawingPadding()
                        .padding(20.dp),
                    verticalArrangement = Arrangement.spacedBy(10.dp)
                ) {
                    Text(
                        text = "Native",
                        style = TextStyle(
                            fontSize = 28.sp,
                            fontWeight = FontWeight.Bold
                        )
                    )
                    Text(
                        text = "This app can be opened using a custom URL scheme.",
                        modifier = Modifier.padding(bottom = 10.dp),
                        style = TextStyle(
                            fontSize = 18.sp
                        ),
                    )
                    WebpageButton()
                    Text(
                        text = "The webpage acts as a stand-in for an auth flow that may require 2FA.",
                        style = TextStyle(
                            fontSize = 18.sp
                        )
                    )
                    Text(
                        text = "We don't want this closing when pausing the app.",
                        modifier = Modifier.padding(bottom = 10.dp),
                        style = TextStyle(
                            fontSize = 18.sp
                        )
                    )
                    Text(
                        text = "The app icon for this app is green.",
                        style = TextStyle(
                            fontSize = 15.sp
                        )
                    )
                }
            }
        }
    }

    override fun onNewIntent(intent: Intent) {
        super.onNewIntent(intent)

        print("onNewIntent: ")
        println(intent.getStringExtra("data"))
    }
}

@Composable
fun WebpageButton(modifier: Modifier = Modifier) {
    val context = LocalContext.current
    Button(
        modifier = modifier,
        onClick = {
            (CustomTabsIntent.Builder().build())
                .launchUrl(context, Uri.parse("https://www.google.com"))
        }) {
        Text(text = "Open Webpage")
    }
}