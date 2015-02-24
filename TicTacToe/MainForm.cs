using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using SpeechLib;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private int Randbtn = -1;
        private Random rand = new Random();
        private Image _X = Properties.Resources.X;
        private Image _O = Properties.Resources.O;
        private string _CurrentPlayer = "X";
        private List<PictureBox> Col1 = new List<PictureBox>(3);
        private List<PictureBox> Col2 = new List<PictureBox>(3);
        private List<PictureBox> Col3 = new List<PictureBox>(3);
        private List<PictureBox> Diag1 = new List<PictureBox>(3);
        private List<PictureBox> Diag2 = new List<PictureBox>(3);
        private List<PictureBox> Row1 = new List<PictureBox>(3);
        private List<PictureBox> Row2 = new List<PictureBox>(3);
        private List<PictureBox> Row3 = new List<PictureBox>(3);
        private List<List<PictureBox>> Winnings = new List<List<PictureBox>>(8);

        public MainForm()
        {
            InitializeComponent();
            Init();
            ResetBoard();
        }

        private void AIMove()
        {
            // Win
            if (slot1.BackgroundImage == null && slot2.BackgroundImage == _O && slot3.BackgroundImage == _O && slot4.BackgroundImage != null && slot5.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot8.BackgroundImage != null && slot9.BackgroundImage != null)
                slot1.BackgroundImage = _O;
            else
            {
                if (slot1.BackgroundImage == null && slot4.BackgroundImage == _O && slot7.BackgroundImage == _O && slot2.BackgroundImage != null && slot3.BackgroundImage != null && slot5.BackgroundImage != null && slot6.BackgroundImage != null && slot8.BackgroundImage != null && slot9.BackgroundImage != null)
                    slot1.BackgroundImage = _O;
                else
                {
                    if (slot1.BackgroundImage == null && slot5.BackgroundImage == _O && slot9.BackgroundImage == _O && slot2.BackgroundImage != null && slot3.BackgroundImage != null && slot4.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot8.BackgroundImage != null)
                        slot1.BackgroundImage = _O;
                    else
                    {
                        if (slot2.BackgroundImage == null && slot1.BackgroundImage == _O && slot3.BackgroundImage == _O && slot4.BackgroundImage != null && slot5.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot8.BackgroundImage != null && slot9.BackgroundImage != null)
                            slot2.BackgroundImage = _O;
                        else
                        {
                            if (slot2.BackgroundImage == null && slot5.BackgroundImage == _O && slot8.BackgroundImage == _O && slot1.BackgroundImage != null && slot3.BackgroundImage != null && slot4.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot9.BackgroundImage != null)
                                slot2.BackgroundImage = _O;
                            else
                            {
                                // Rotate 1
                                if (slot9.BackgroundImage == null && slot8.BackgroundImage == _O && slot7.BackgroundImage == _O && slot2.BackgroundImage != null && slot5.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null && slot9.BackgroundImage != null)
                                    slot9.BackgroundImage = _O;
                                else
                                {
                                    if (slot1.BackgroundImage == null && slot2.BackgroundImage == _O && slot3.BackgroundImage == _O && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot5.BackgroundImage != null && slot8.BackgroundImage != null && slot4.BackgroundImage != null && slot9.BackgroundImage != null)
                                        slot9.BackgroundImage = _O;
                                    else
                                    {
                                        if (slot9.BackgroundImage == null && slot5.BackgroundImage == _O && slot1.BackgroundImage == _O && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null)
                                            slot9.BackgroundImage = _O;
                                        else
                                        {
                                            if (slot8.BackgroundImage == null && slot9.BackgroundImage == _O && slot7.BackgroundImage == _O && slot2.BackgroundImage != null && slot5.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null && slot9.BackgroundImage != null)
                                                slot8.BackgroundImage = _O;
                                            else
                                            {
                                                if (slot8.BackgroundImage == null && slot5.BackgroundImage == _O && slot2.BackgroundImage == _O && slot3.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot9.BackgroundImage != null)
                                                    slot9.BackgroundImage = _O;
                                                else
                                                {
                                                    // Rotate 2
                                                    if (slot9.BackgroundImage == null && slot8.BackgroundImage == _O && slot7.BackgroundImage == _O && slot6.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null && slot7.BackgroundImage != null)
                                                        slot9.BackgroundImage = _O;
                                                    else
                                                    {
                                                        if (slot9.BackgroundImage == null && slot6.BackgroundImage == _O && slot3.BackgroundImage == _O && slot8.BackgroundImage != null && slot7.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot2.BackgroundImage != null && slot7.BackgroundImage != null)
                                                            slot9.BackgroundImage = _O;
                                                        else
                                                        {
                                                            if (slot9.BackgroundImage == null && slot5.BackgroundImage == _O && slot1.BackgroundImage == _O && slot8.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null)
                                                                slot9.BackgroundImage = _O;
                                                            else
                                                            {
                                                                if (slot8.BackgroundImage == null && slot9.BackgroundImage == _O && slot7.BackgroundImage == _O && slot6.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                    slot8.BackgroundImage = _O;
                                                                else
                                                                {
                                                                    if (slot8.BackgroundImage == null && slot5.BackgroundImage == _O && slot2.BackgroundImage == _O && slot9.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                        slot9.BackgroundImage = _O;
                                                                    else
                                                                    {
                                                                        // Rotate 3
                                                                        if (slot7.BackgroundImage == null && slot4.BackgroundImage == _O && slot1.BackgroundImage == _O && slot8.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                            slot7.BackgroundImage = _O;
                                                                        else
                                                                        {
                                                                            if (slot7.BackgroundImage == null && slot8.BackgroundImage == _O && slot9.BackgroundImage == _O && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot6.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                slot7.BackgroundImage = _O;
                                                                            else
                                                                            {
                                                                                if (slot7.BackgroundImage == null && slot5.BackgroundImage == _O && slot3.BackgroundImage == _O && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null)
                                                                                    slot7.BackgroundImage = _O;
                                                                                else
                                                                                {
                                                                                    if (slot4.BackgroundImage == null && slot7.BackgroundImage == _O && slot1.BackgroundImage == _O && slot8.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                        slot4.BackgroundImage = _O;
                                                                                    else
                                                                                    {
                                                                                        if (slot4.BackgroundImage == null && slot5.BackgroundImage == _O && slot6.BackgroundImage == _O && slot7.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                            slot7.BackgroundImage = _O;
                                                                                        else
                                                                                        {
                                                                                            // Defend
                                                                                            if (slot1.BackgroundImage == null && slot2.BackgroundImage == _X && slot3.BackgroundImage == _X)
                                                                                                slot1.BackgroundImage = _O;
                                                                                            else
                                                                                            {
                                                                                                if (slot1.BackgroundImage == null && slot4.BackgroundImage == _X && slot7.BackgroundImage == _X)
                                                                                                    slot1.BackgroundImage = _O;
                                                                                                else
                                                                                                {
                                                                                                    if (slot1.BackgroundImage == null && slot5.BackgroundImage == _X && slot9.BackgroundImage == _X)
                                                                                                        slot1.BackgroundImage = _O;
                                                                                                    else
                                                                                                    {
                                                                                                        if (slot2.BackgroundImage == null && slot1.BackgroundImage == _X && slot3.BackgroundImage == _X)
                                                                                                            slot2.BackgroundImage = _O;
                                                                                                        else
                                                                                                        {
                                                                                                            if (slot2.BackgroundImage == null && slot5.BackgroundImage == _X && slot8.BackgroundImage == _X)
                                                                                                                slot2.BackgroundImage = _O;
                                                                                                            else
                                                                                                            {
                                                                                                                // Rotate 1
                                                                                                                if (slot3.BackgroundImage == null && slot6.BackgroundImage == _X && slot9.BackgroundImage == _X && slot6.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                    slot3.BackgroundImage = _O;
                                                                                                                else
                                                                                                                {
                                                                                                                    if (slot3.BackgroundImage == null && slot2.BackgroundImage == _X && slot1.BackgroundImage == _X && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot5.BackgroundImage != null && slot8.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                        slot3.BackgroundImage = _O;
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (slot3.BackgroundImage == null && slot5.BackgroundImage == _X && slot7.BackgroundImage == _X && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null)
                                                                                                                            slot3.BackgroundImage = _O;
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (slot6.BackgroundImage == null && slot3.BackgroundImage == _X && slot9.BackgroundImage == _X && slot2.BackgroundImage != null && slot5.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                                slot6.BackgroundImage = _O;
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (slot6.BackgroundImage == null && slot5.BackgroundImage == _X && slot4.BackgroundImage == _X && slot3.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                                    slot3.BackgroundImage = _O;
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    // Rotate 2
                                                                                                                                    if (slot9.BackgroundImage == null && slot8.BackgroundImage == _X && slot7.BackgroundImage == _X && slot8.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                        slot9.BackgroundImage = _O;
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (slot9.BackgroundImage == null && slot6.BackgroundImage == _X && slot3.BackgroundImage == _X && slot8.BackgroundImage != null && slot7.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                            slot9.BackgroundImage = _O;
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (slot9.BackgroundImage == null && slot5.BackgroundImage == _X && slot1.BackgroundImage == _X && slot8.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null)
                                                                                                                                                slot9.BackgroundImage = _O;
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (slot8.BackgroundImage == null && slot9.BackgroundImage == _X && slot7.BackgroundImage == _X && slot6.BackgroundImage != null && slot5.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                                    slot8.BackgroundImage = _O;
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (slot8.BackgroundImage == null && slot5.BackgroundImage == _X && slot2.BackgroundImage == _X && slot9.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                                        slot9.BackgroundImage = _O;
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        // Rotate 3
                                                                                                                                                        if (slot7.BackgroundImage == null && slot4.BackgroundImage == _X && slot1.BackgroundImage == _X && slot4.BackgroundImage != null && slot5.BackgroundImage != null && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                            slot7.BackgroundImage = _O;
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (slot7.BackgroundImage == null && slot8.BackgroundImage == _X && slot9.BackgroundImage == _X && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                slot7.BackgroundImage = _O;
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (slot7.BackgroundImage == null && slot5.BackgroundImage == _X && slot3.BackgroundImage == _X && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null)
                                                                                                                                                                    slot7.BackgroundImage = _O;
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (slot4.BackgroundImage == null && slot7.BackgroundImage == _X && slot1.BackgroundImage == _X && slot8.BackgroundImage != null && slot5.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                        slot4.BackgroundImage = _O;
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (slot4.BackgroundImage == null && slot5.BackgroundImage == _X && slot6.BackgroundImage == _X && slot7.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                            slot7.BackgroundImage = _O;
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            // Defend Two Moves
                                                                                                                                                                            if (slot2.BackgroundImage == null && slot5.BackgroundImage == _O && slot3.BackgroundImage == _X && slot7.BackgroundImage == _X)
                                                                                                                                                                                slot2.BackgroundImage = _O;
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                if (slot1.BackgroundImage == null && slot5.BackgroundImage == _O && slot2.BackgroundImage == _X && slot4.BackgroundImage == _X)
                                                                                                                                                                                    slot1.BackgroundImage = _O;
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    if (slot1.BackgroundImage == null && slot5.BackgroundImage == _O && slot3.BackgroundImage == _X && slot4.BackgroundImage == _X)
                                                                                                                                                                                        slot1.BackgroundImage = _O;
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        if (slot1.BackgroundImage == null && slot5.BackgroundImage == _O && slot3.BackgroundImage == _X && slot7.BackgroundImage == _X)
                                                                                                                                                                                            slot1.BackgroundImage = _O;
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            if (slot2.BackgroundImage == null && slot5.BackgroundImage == _X && slot1.BackgroundImage != null && slot3.BackgroundImage != null && slot4.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot9.BackgroundImage != null && slot8.BackgroundImage == null)
                                                                                                                                                                                                slot2.BackgroundImage = _O;
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                if (slot1.BackgroundImage == null && slot5.BackgroundImage == _X && slot2.BackgroundImage != null && slot3.BackgroundImage != null && slot4.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot8.BackgroundImage != null && slot9.BackgroundImage == null)
                                                                                                                                                                                                    slot1.BackgroundImage = _O;
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    // Rotate 1 Two Moves
                                                                                                                                                                                                    if (slot6.BackgroundImage == null && slot5.BackgroundImage == _O && slot9.BackgroundImage == _X && slot1.BackgroundImage == _X)
                                                                                                                                                                                                        slot6.BackgroundImage = _O;
                                                                                                                                                                                                    else
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (slot3.BackgroundImage == null && slot5.BackgroundImage == _O && slot6.BackgroundImage == _X && slot2.BackgroundImage == _X && slot8.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                                                                                                            slot3.BackgroundImage = _O;
                                                                                                                                                                                                        else
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (slot3.BackgroundImage == null && slot5.BackgroundImage == _O && slot9.BackgroundImage == _X && slot2.BackgroundImage == _X && slot8.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                                                                                                                slot3.BackgroundImage = _O;
                                                                                                                                                                                                            else
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (slot3.BackgroundImage == null && slot5.BackgroundImage == _O && slot9.BackgroundImage == _X && slot1.BackgroundImage == _X && slot8.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage != null)
                                                                                                                                                                                                                    slot3.BackgroundImage = _O;
                                                                                                                                                                                                                else
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (slot6.BackgroundImage == null && slot5.BackgroundImage == _X && slot3.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot7.BackgroundImage != null && slot4.BackgroundImage == null)
                                                                                                                                                                                                                        slot6.BackgroundImage = _O;
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (slot3.BackgroundImage == null && slot5.BackgroundImage == _X && slot6.BackgroundImage != null && slot9.BackgroundImage != null && slot2.BackgroundImage != null && slot8.BackgroundImage != null && slot1.BackgroundImage != null && slot4.BackgroundImage != null && slot7.BackgroundImage == null)
                                                                                                                                                                                                                            slot3.BackgroundImage = _O;
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            // Rotate 2 Two Moves
                                                                                                                                                                                                                            if (slot8.BackgroundImage == null && slot5.BackgroundImage == _O && slot7.BackgroundImage == _X && slot3.BackgroundImage == _X)
                                                                                                                                                                                                                                slot8.BackgroundImage = _O;
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                if (slot9.BackgroundImage == null && slot5.BackgroundImage == _O && slot8.BackgroundImage == _X && slot6.BackgroundImage == _X && slot4.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                                                                                                                    slot9.BackgroundImage = _O;
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    if (slot9.BackgroundImage == null && slot5.BackgroundImage == _O && slot7.BackgroundImage == _X && slot6.BackgroundImage == _X && slot4.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                                                                                                                        slot9.BackgroundImage = _O;
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        if (slot9.BackgroundImage == null && slot5.BackgroundImage == _O && slot7.BackgroundImage == _X && slot3.BackgroundImage == _X && slot4.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage != null)
                                                                                                                                                                                                                                            slot9.BackgroundImage = _O;
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            if (slot8.BackgroundImage == null && slot5.BackgroundImage == _X && slot9.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot1.BackgroundImage != null && slot2.BackgroundImage == null)
                                                                                                                                                                                                                                                slot8.BackgroundImage = _O;
                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                if (slot9.BackgroundImage == null && slot5.BackgroundImage == _X && slot8.BackgroundImage != null && slot7.BackgroundImage != null && slot6.BackgroundImage != null && slot4.BackgroundImage != null && slot3.BackgroundImage != null && slot2.BackgroundImage != null && slot1.BackgroundImage == null)
                                                                                                                                                                                                                                                    slot9.BackgroundImage = _O;
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    // Rotate 3 Two Moves
                                                                                                                                                                                                                                                    if (slot4.BackgroundImage == null && slot5.BackgroundImage == _O && slot1.BackgroundImage == _X && slot9.BackgroundImage == _X)
                                                                                                                                                                                                                                                        slot4.BackgroundImage = _O;
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        if (slot7.BackgroundImage == null && slot5.BackgroundImage == _O && slot4.BackgroundImage == _X && slot8.BackgroundImage == _X && slot2.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                                                                                                            slot7.BackgroundImage = _O;
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            if (slot7.BackgroundImage == null && slot5.BackgroundImage == _O && slot1.BackgroundImage == _X && slot8.BackgroundImage == _X && slot2.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                                                                                                                slot7.BackgroundImage = _O;
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                if (slot7.BackgroundImage == null && slot5.BackgroundImage == _O && slot1.BackgroundImage == _X && slot9.BackgroundImage == _X && slot2.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage != null)
                                                                                                                                                                                                                                                                    slot7.BackgroundImage = _O;
                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    if (slot4.BackgroundImage == null && slot5.BackgroundImage == _X && slot7.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot3.BackgroundImage != null && slot6.BackgroundImage == null)
                                                                                                                                                                                                                                                                        slot4.BackgroundImage = _O;
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (slot7.BackgroundImage == null && slot5.BackgroundImage == _X && slot4.BackgroundImage != null && slot1.BackgroundImage != null && slot8.BackgroundImage != null && slot2.BackgroundImage != null && slot9.BackgroundImage != null && slot6.BackgroundImage != null && slot3.BackgroundImage == null)
                                                                                                                                                                                                                                                                            slot7.BackgroundImage = _O;
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            RandomMove(-1);
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ComputerPlay()
        {
            StatusText.Text = "Single Player Mode";

            AIMove();

            Image winner = CheckForAWinner();
            if (winner != null)
            {
                StatusText.Text = "Winner: Computer";

                bg.RunWorkerAsync(winner);

                //MessageBox.Show(StatusText.Text);

                foreach (List<PictureBox> buttonList in Winnings)
                {
                    foreach (PictureBox button in buttonList)
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        private void RandomMove(int move)
        {
            if (move != -1)
                Randbtn = move;
            else
                Randbtn = rand.Next(1,9);

            switch (Randbtn)
            {
                case 1:
                    if (slot1.BackgroundImage == null)
                    {
                        slot1.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 2;
                case 2:
                    if (slot2.BackgroundImage == null)
                    {
                        slot2.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 3;
                case 3:
                    if (slot3.BackgroundImage == null)
                    {
                        slot3.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 4;
                case 4:
                    if (slot4.BackgroundImage == null)
                    {
                        slot4.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 5;
                case 5:
                    if (slot5.BackgroundImage == null)
                    {
                        slot5.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 6;
                case 6:
                    if (slot6.BackgroundImage == null)
                    {
                        slot6.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 7;
                case 7:
                    if (slot7.BackgroundImage == null)
                    {
                        slot7.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 8;
                case 8:
                    if (slot8.BackgroundImage == null)
                    {
                        slot8.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto case 9;
                case 9:
                    if (slot9.BackgroundImage == null)
                    {
                        slot9.BackgroundImage = _O;
                        break;
                    }
                    else
                        goto default;
                default:
                    if (slot1.BackgroundImage == null)
                        slot1.BackgroundImage = _O;
                    else
                    if (slot2.BackgroundImage == null)
                        slot2.BackgroundImage = _O;
                    else
                    if (slot3.BackgroundImage == null)
                        slot3.BackgroundImage = _O;
                    else
                    if (slot4.BackgroundImage == null)
                        slot4.BackgroundImage = _O;
                    else
                    if (slot5.BackgroundImage == null)
                        slot5.BackgroundImage = _O;
                    else
                    if (slot6.BackgroundImage == null)
                        slot6.BackgroundImage = _O;
                    else
                    if (slot7.BackgroundImage == null)
                        slot7.BackgroundImage = _O;
                    else
                    if (slot8.BackgroundImage == null)
                        slot8.BackgroundImage = _O;
                    else
                    if (slot9.BackgroundImage == null)
                        slot9.BackgroundImage = _O;
                    break;
            }
        }

        private string CurrentPlayer
        {
            get { return _CurrentPlayer; }
            set
            {
                _CurrentPlayer = value;
                StatusText.Text = string.Format("Turn: Player {0}", value);
            }
        }

        private Image CheckForAWinner()
        {
            foreach (List<PictureBox> possibility in Winnings)
            {
                if (possibility[0].BackgroundImage == possibility[1].BackgroundImage && possibility[1].BackgroundImage == possibility[2].BackgroundImage)
                {
                    return possibility[0].BackgroundImage;
                }
            }

            return null;
        }

        private void GameMove_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).BackgroundImage == null)
            {
                if (MultiPlayerMenu.Checked == true)
                {
                    if (_CurrentPlayer == "X")
                        ((PictureBox)sender).BackgroundImage = _X;
                    else
                        ((PictureBox)sender).BackgroundImage = _O;

                    Image winner = CheckForAWinner();
                    if (winner == null)
                        SwitchPlayer();
                    else
                        WeHaveAWinner(_CurrentPlayer);
                }
                else
                {
                    ((PictureBox)sender).BackgroundImage = _X;
                    Image winner = CheckForAWinner();
                    if (winner != null)
                    {
                        StatusText.Text = "Winner: Player X";

                        bg.RunWorkerAsync(winner);

                        //MessageBox.Show(StatusText.Text);

                        foreach (List<PictureBox> buttonList in Winnings)
                        {
                            foreach (PictureBox button in buttonList)
                            {
                                button.Enabled = false;
                            }
                        }
                    }
                    else
                        ComputerPlay();
                }
            }
            else
                StatusText.Text = "You can't play here";
        }

        void Init()
        {
            Row1.AddRange(new PictureBox[] { slot1, slot2, slot3 });
            Row2.AddRange(new PictureBox[] { slot4, slot5, slot6 });
            Row3.AddRange(new PictureBox[] { slot7, slot8, slot9 });

            Col1.AddRange(new PictureBox[] { slot1, slot4, slot7 });
            Col2.AddRange(new PictureBox[] { slot2, slot5, slot8 });
            Col3.AddRange(new PictureBox[] { slot3, slot6, slot9 });

            Diag1.AddRange(new PictureBox[] { slot1, slot5, slot9 });
            Diag2.AddRange(new PictureBox[] { slot3, slot5, slot7 });

            Winnings.AddRange(new List<PictureBox>[] { Row1, Row2, Row3, Col1, Col2, Col3, Diag1, Diag2 });
        }

        private void ResetBoard()
        {
            foreach (List<PictureBox> buttonList in Winnings)
            {
                foreach (PictureBox button in buttonList)
                {
                    button.BackgroundImage = null;
                    button.Enabled = true;
                }
            }
            CurrentPlayer = "X";
        }

        private void SwitchPlayer()
        {
            if (_CurrentPlayer == "X")
                CurrentPlayer = "O";
            else
                CurrentPlayer = "X";
        }

        private void WeHaveAWinner(string winner)
        {
            StatusText.Text = string.Format("Winner: Player {0}", winner);
            MessageBox.Show(StatusText.Text);

            bg.RunWorkerAsync(winner);

            foreach (List<PictureBox> buttonList in Winnings)
            {
                foreach (PictureBox button in buttonList)
                {
                    button.Enabled = false;
                }
            }
        }

        private void Speak(string Winner)
        {
            SpVoice Talk = new SpVoice();
            Talk.Speak("Winner is " + Winner);
        }

        private void NewGameMenu_Click(object sender, EventArgs e)
        {
            ResetBoard();
            //if (SinglePlayerMenu.Checked == true)
                //ComputerPlay();
        }

        private void SinglePlayerMenu_Click(object sender, EventArgs e)
        {
            MultiPlayerMenu.Checked = false;
            SinglePlayerMenu.Enabled = false;
            MultiPlayerMenu.Enabled = true;
            SinglePlayerMenu.Checked = true;
            ResetBoard();
            //ComputerPlay();
        }

        private void MultiPlayerMenu_Click(object sender, EventArgs e)
        {
            SinglePlayerMenu.Checked = false;
            MultiPlayerMenu.Enabled = false;
            SinglePlayerMenu.Enabled = true;
            MultiPlayerMenu.Checked = true;
            ResetBoard();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ComputerPlay();
            StatusText.Text = "Single Player Mode";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.NumPad1:
                    RandomMove(7);
                    break;
                case Keys.NumPad2:
                    RandomMove(8);
                    break;
                case Keys.NumPad3:
                    RandomMove(9);
                    break;
                case Keys.NumPad4:
                    RandomMove(4);
                    break;
                case Keys.NumPad5:
                    RandomMove(5);
                    break;
                case Keys.NumPad6:
                    RandomMove(6);
                    break;
                case Keys.NumPad7:
                    RandomMove(1);
                    break;
                case Keys.NumPad8:
                    RandomMove(2);
                    break;
                case Keys.NumPad9:
                    RandomMove(3);
                    break;
                case Keys.F11:
                    FullScreenMenu.PerformClick();
                    break;
                case Keys.N :
                    NewGameMenu.PerformClick();
                    break;
                case Keys.Escape:
                    if(this.WindowState == FormWindowState.Maximized)
                        FullScreenMenu.PerformClick();
                    break;
                case Keys.S:
                    SinglePlayerMenu.PerformClick();
                    break;
                case Keys.M:
                    MultiPlayerMenu.PerformClick();
                    break;
                case Keys.Q:
                    Close();
                    break;
            }
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\r\nMohamed Ahmed Abdel Fattah\r\neng.mafattah@hotmail.com","TicTacToe - About",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }

        private void Draw_BackgroundImageChanged(object sender, EventArgs e)
        {
            Image winner = CheckForAWinner();
            if (slot1.BackgroundImage != null && slot2.BackgroundImage != null && slot3.BackgroundImage != null && slot4.BackgroundImage != null && slot5.BackgroundImage != null && slot6.BackgroundImage != null && slot7.BackgroundImage != null && slot8.BackgroundImage != null && slot9.BackgroundImage != null && winner == null)
            {
                StatusText.Text = "It's a Tie";
                MessageBox.Show(StatusText.Text);
                foreach (List<PictureBox> buttonList in Winnings)
                {
                    foreach (PictureBox button in buttonList)
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Height < 350 || this.Width < 250)
            {
                this.Height = 350;
                this.Width = 350;
            }
        }

        private void FullScreenMenu_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                FullScreenMenu.Text = "Exit Full Screen";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                FullScreenMenu.Text = "Full Screen";
            }
        }

        private void bg_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string winner = (string) e.Argument;
            Speak(winner);
        }

    }
}