package com.example.deeplinkinghelper

import android.net.Uri
import android.os.Bundle
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
import com.example.deeplinkinghelper.ui.theme.DeepLinkingHelperTheme

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            DeepLinkingHelperTheme {
                Column(
                    modifier = Modifier
                        .safeDrawingPadding()
                        .padding(20.dp),
                    verticalArrangement = Arrangement.spacedBy(10.dp)
                ) {
                    Text(
                        text = "Deep Linking Helper",
                        style = TextStyle(
                            fontSize = 28.sp,
                            fontWeight = FontWeight.Bold
                        )
                    )
                    DeepLinkButton()
                    Text(
                        text = "This is a helper app for opening the repro apps using a custom URL scheme.",
                        style = TextStyle(
                            fontSize = 18.sp
                        )
                    )
                    Text(
                        text = "The app icon for this app is orange.",
                        style = TextStyle(
                            fontSize = 15.sp
                        ))
                }
            }
        }
    }
}

@Composable
fun DeepLinkButton(modifier: Modifier = Modifier) {
    val context = LocalContext.current
    Button(
        modifier = modifier,
        onClick = {
            (CustomTabsIntent.Builder().build())
                .launchUrl(context, Uri.parse("hello://world/123"))
        }) {
        Text(text = "Open App")
    }
}