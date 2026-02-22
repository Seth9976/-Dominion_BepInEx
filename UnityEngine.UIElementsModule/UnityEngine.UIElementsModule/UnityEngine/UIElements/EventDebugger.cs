using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A5 RID: 165
	public class EventDebugger : Object
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00005911 File Offset: 0x00003B11
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebugger()
		{
			Il2CppClassPointerStore<EventDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebugger>.NativeClassPtr);
			EventDebugger.NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebugger>.NativeClassPtr, 100664141);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00028448 File Offset: 0x00026648
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebugger.NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000594A File Offset: 0x00003B4A
		public EventDebugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00005953 File Offset: 0x00003B53
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00005960 File Offset: 0x00003B60
		public IPanel panel
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0000596D File Offset: 0x00003B6D
		public void UpdateModificationCount()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000597A File Offset: 0x00003B7A
		public void BeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			this.AddBeginProcessEvent(evt, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0000598D File Offset: 0x00003B8D
		public void EndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddEndProcessEvent(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00028490 File Offset: 0x00026690
		public void LogCall(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			this.AddCallObject(cbHashCode, cbName, evt, propagationHasStopped, immediatePropagationHasStopped, defaultHasBeenPrevented, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000059A1 File Offset: 0x00003BA1
		public void LogIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddIMGUICall(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000059B5 File Offset: 0x00003BB5
		public void LogExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			this.AddExecuteDefaultAction(evt, phase, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000284BC File Offset: 0x000266BC
		public void LogPropagationPathsInternal(EventBase evt, PropagationPaths paths)
		{
			PropagationPaths propagationPaths = ((paths == null) ? new PropagationPaths() : new PropagationPaths(paths));
			this.AddPropagationPaths(evt, propagationPaths);
			this.UpdateModificationCount();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000059CB File Offset: 0x00003BCB
		public List<EventDebuggerCallTrace> GetCalls(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000059D8 File Offset: 0x00003BD8
		public List<EventDebuggerDefaultActionTrace> GetDefaultActions(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000059E5 File Offset: 0x00003BE5
		public List<EventDebuggerPathTrace> GetPropagationPaths(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000059F2 File Offset: 0x00003BF2
		public List<EventDebuggerTrace> GetBeginEndProcessedEvents(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000059FF File Offset: 0x00003BFF
		public long GetModificationCount(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00005A0C File Offset: 0x00003C0C
		public void ClearLogs()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000284EC File Offset: 0x000266EC
		public void ReplayEvents(List<EventDebuggerEventRecord> eventBases)
		{
			bool flag = eventBases == null;
			if (!flag)
			{
				List<EventDebuggerEventRecord>.Enumerator enumerator = eventBases.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						EventDebuggerEventRecord eventDebuggerEventRecord = enumerator.Current;
						Event @event = new Event
						{
							button = eventDebuggerEventRecord.button,
							clickCount = eventDebuggerEventRecord.clickCount,
							modifiers = eventDebuggerEventRecord.modifiers,
							mousePosition = eventDebuggerEventRecord.mousePosition
						};
						bool flag2 = eventDebuggerEventRecord.eventTypeId == EventBase<MouseMoveEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
						if (flag2)
						{
							@event.type = EventType.MouseMove;
							this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.MouseMove), this.panel, DispatchMode.Default);
						}
						else
						{
							bool flag3 = eventDebuggerEventRecord.eventTypeId == EventBase<MouseDownEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
							if (flag3)
							{
								@event.type = EventType.MouseDown;
								this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.MouseDown), this.panel, DispatchMode.Default);
							}
							else
							{
								bool flag4 = eventDebuggerEventRecord.eventTypeId == EventBase<MouseUpEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
								if (flag4)
								{
									@event.type = EventType.MouseUp;
									this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.MouseUp), this.panel, DispatchMode.Default);
								}
								else
								{
									bool flag5 = eventDebuggerEventRecord.eventTypeId == EventBase<ContextClickEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
									if (flag5)
									{
										@event.type = EventType.ContextClick;
										this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.ContextClick), this.panel, DispatchMode.Default);
									}
									else
									{
										bool flag6 = eventDebuggerEventRecord.eventTypeId == EventBase<MouseEnterWindowEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
										if (flag6)
										{
											@event.type = EventType.MouseEnterWindow;
											this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.MouseEnterWindow), this.panel, DispatchMode.Default);
										}
										else
										{
											bool flag7 = eventDebuggerEventRecord.eventTypeId == EventBase<MouseLeaveWindowEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
											if (flag7)
											{
												@event.type = EventType.MouseLeaveWindow;
												this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.MouseLeaveWindow), this.panel, DispatchMode.Default);
											}
											else
											{
												bool flag8 = eventDebuggerEventRecord.eventTypeId == EventBase<WheelEvent>.TypeId() && eventDebuggerEventRecord.hasUnderlyingPhysicalEvent;
												if (flag8)
												{
													@event.type = EventType.ScrollWheel;
													@event.delta = eventDebuggerEventRecord.delta;
													this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.ScrollWheel), this.panel, DispatchMode.Default);
												}
												else
												{
													bool flag9 = eventDebuggerEventRecord.eventTypeId == EventBase<KeyDownEvent>.TypeId();
													if (flag9)
													{
														@event.type = EventType.KeyDown;
														@event.character = eventDebuggerEventRecord.character;
														@event.keyCode = eventDebuggerEventRecord.keyCode;
														this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.KeyDown), this.panel, DispatchMode.Default);
													}
													else
													{
														bool flag10 = eventDebuggerEventRecord.eventTypeId == EventBase<KeyUpEvent>.TypeId();
														if (flag10)
														{
															@event.type = EventType.KeyUp;
															@event.character = eventDebuggerEventRecord.character;
															@event.keyCode = eventDebuggerEventRecord.keyCode;
															this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.KeyUp), this.panel, DispatchMode.Default);
														}
														else
														{
															bool flag11 = eventDebuggerEventRecord.eventTypeId == EventBase<ValidateCommandEvent>.TypeId();
															if (flag11)
															{
																@event.type = EventType.ValidateCommand;
																@event.commandName = eventDebuggerEventRecord.commandName;
																this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.ValidateCommand), this.panel, DispatchMode.Default);
															}
															else
															{
																bool flag12 = eventDebuggerEventRecord.eventTypeId == EventBase<ExecuteCommandEvent>.TypeId();
																if (flag12)
																{
																	@event.type = EventType.ExecuteCommand;
																	@event.commandName = eventDebuggerEventRecord.commandName;
																	this.panel.dispatcher.Dispatch(UIElementsUtility.CreateEvent(@event, EventType.ExecuteCommand), this.panel, DispatchMode.Default);
																}
																else
																{
																	bool flag13 = eventDebuggerEventRecord.eventTypeId == EventBase<IMGUIEvent>.TypeId();
																	if (flag13)
																	{
																		string text = "Skipped IMGUI event (";
																		string eventBaseName = eventDebuggerEventRecord.eventBaseName;
																		string text2 = "): ";
																		EventDebuggerEventRecord eventDebuggerEventRecord2 = eventDebuggerEventRecord;
																		Debug.Log(String.Concat(text, eventBaseName, text2, (eventDebuggerEventRecord2 != null) ? eventDebuggerEventRecord2.ToString() : null));
																		continue;
																	}
																	string text3 = "Skipped event (";
																	string eventBaseName2 = eventDebuggerEventRecord.eventBaseName;
																	string text4 = "): ";
																	EventDebuggerEventRecord eventDebuggerEventRecord3 = eventDebuggerEventRecord;
																	Debug.Log(String.Concat(text3, eventBaseName2, text4, (eventDebuggerEventRecord3 != null) ? eventDebuggerEventRecord3.ToString() : null));
																	continue;
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
						string text5 = "Replayed event (";
						string eventBaseName3 = eventDebuggerEventRecord.eventBaseName;
						string text6 = "): ";
						Event event2 = @event;
						Debug.Log(String.Concat(text5, eventBaseName3, text6, (event2 != null) ? event2.ToString() : null));
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00005A19 File Offset: 0x00003C19
		public Dictionary<string, long> ComputeHistogram(List<EventDebuggerEventRecord> eventBases)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00005A26 File Offset: 0x00003C26
		public void AddCallObject(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00005A33 File Offset: 0x00003C33
		public void AddExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00005A40 File Offset: 0x00003C40
		public void AddPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00005A4D File Offset: 0x00003C4D
		public void AddIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00005A5A File Offset: 0x00003C5A
		public void AddBeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00005A67 File Offset: 0x00003C67
		public void AddEndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00028994 File Offset: 0x00026B94
		public static string GetObjectDisplayName(Object obj, [Optional] bool withHashCode)
		{
			bool flag = obj == null;
			string text;
			if (flag)
			{
				text = String.Empty;
			}
			else
			{
				string text2 = obj.GetType().Name;
				bool flag2 = obj.TryCast<VisualElement>() != null;
				if (flag2)
				{
					VisualElement visualElement = obj.TryCast<VisualElement>();
					bool flag3 = !String.IsNullOrEmpty(visualElement.name);
					if (flag3)
					{
						text2 = String.Concat(text2, "#", visualElement.name);
					}
				}
				if (withHashCode)
				{
					text2 = String.Concat(text2, " (", obj.GetHashCode().ToString("x8"), ")");
				}
				text = text2;
			}
			return text;
		}

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0;
	}
}
