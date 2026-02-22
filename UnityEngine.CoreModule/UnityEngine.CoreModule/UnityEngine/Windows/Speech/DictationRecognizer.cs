using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000ED RID: 237
	public sealed class DictationRecognizer : Object
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x0004F078 File Offset: 0x0004D278
		// Note: this type is marked as 'beforefieldinit'.
		static DictationRecognizer()
		{
			Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "DictationRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
			DictationRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "m_Recognizer");
			DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesis");
			DictationRecognizer.NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResult");
			DictationRecognizer.NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationComplete");
			DictationRecognizer.NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationError");
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100664778);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100664779);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100664780);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100664781);
			DictationRecognizer.CreateDelegateField = IL2CPP.ResolveICall<DictationRecognizer.CreateDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Create");
			DictationRecognizer.StartDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StartDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Start");
			DictationRecognizer.StopDelegateField = IL2CPP.ResolveICall<DictationRecognizer.StopDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Stop");
			DictationRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::Destroy");
			DictationRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<DictationRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::DestroyThreaded");
			DictationRecognizer.GetStatusDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetStatusDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetStatus");
			DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetAutoSilenceTimeoutSeconds");
			DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetAutoSilenceTimeoutSeconds");
			DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::GetInitialSilenceTimeoutSeconds");
			DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField = IL2CPP.ResolveICall<DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate>("UnityEngine.Windows.Speech.DictationRecognizer::SetInitialSilenceTimeoutSeconds");
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79680, XrefRangeEnd = 79681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0004F238 File Offset: 0x0004D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79681, XrefRangeEnd = 79682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumConfidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0004F288 File Offset: 0x0004D488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79682, XrefRangeEnd = 79683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79683, XrefRangeEnd = 79684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0000BDD1 File Offset: 0x00009FD1
		public DictationRecognizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0004F318 File Offset: 0x0004D518
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0000BDDA File Offset: 0x00009FDA
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0004F340 File Offset: 0x0004D540
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0000BDF5 File Offset: 0x00009FF5
		public unsafe DictationRecognizer.DictationHypothesisDelegate DictationHypothesis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationHypothesisDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0004F370 File Offset: 0x0004D570
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0000BE14 File Offset: 0x0000A014
		public unsafe DictationRecognizer.DictationResultDelegate DictationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationResultDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x0000BE33 File Offset: 0x0000A033
		public unsafe DictationRecognizer.DictationCompletedDelegate DictationComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationCompletedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0004F3D0 File Offset: 0x0004D5D0
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0000BE52 File Offset: 0x0000A052
		public unsafe DictationRecognizer.DictationErrorHandler DictationError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationErrorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0000BE71 File Offset: 0x0000A071
		public static IntPtr Create(Object self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint)
		{
			return DictationRecognizer.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), minimumConfidence, topicConstraint);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0000BE85 File Offset: 0x0000A085
		public static void Start(IntPtr self)
		{
			DictationRecognizer.StartDelegateField(self);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0000BE92 File Offset: 0x0000A092
		public static void Stop(IntPtr self)
		{
			DictationRecognizer.StopDelegateField(self);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0000BE9F File Offset: 0x0000A09F
		public static void Destroy(IntPtr self)
		{
			DictationRecognizer.DestroyDelegateField(self);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		public static void DestroyThreaded(IntPtr self)
		{
			DictationRecognizer.DestroyThreadedDelegateField(self);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0000BEB9 File Offset: 0x0000A0B9
		public static SpeechSystemStatus GetStatus(IntPtr self)
		{
			return DictationRecognizer.GetStatusDelegateField(self);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0000BEC6 File Offset: 0x0000A0C6
		public static float GetAutoSilenceTimeoutSeconds(IntPtr self)
		{
			return DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegateField(self);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0000BED3 File Offset: 0x0000A0D3
		public static void SetAutoSilenceTimeoutSeconds(IntPtr self, float value)
		{
			DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegateField(self, value);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000BEE1 File Offset: 0x0000A0E1
		public static float GetInitialSilenceTimeoutSeconds(IntPtr self)
		{
			return DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegateField(self);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0000BEEE File Offset: 0x0000A0EE
		public static void SetInitialSilenceTimeoutSeconds(IntPtr self, float value)
		{
			DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegateField(self, value);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public void add_DictationHypothesis(DictationRecognizer.DictationHypothesisDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0000BF09 File Offset: 0x0000A109
		public void remove_DictationHypothesis(DictationRecognizer.DictationHypothesisDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0000BF16 File Offset: 0x0000A116
		public void add_DictationResult(DictationRecognizer.DictationResultDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000BF23 File Offset: 0x0000A123
		public void remove_DictationResult(DictationRecognizer.DictationResultDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0000BF30 File Offset: 0x0000A130
		public void add_DictationComplete(DictationRecognizer.DictationCompletedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0000BF3D File Offset: 0x0000A13D
		public void remove_DictationComplete(DictationRecognizer.DictationCompletedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0000BF4A File Offset: 0x0000A14A
		public void add_DictationError(DictationRecognizer.DictationErrorHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000BF57 File Offset: 0x0000A157
		public void remove_DictationError(DictationRecognizer.DictationErrorHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0004F400 File Offset: 0x0004D600
		public SpeechSystemStatus Status
		{
			get
			{
				return (this.m_Recognizer != IntPtr.Zero) ? DictationRecognizer.GetStatus(this.m_Recognizer) : SpeechSystemStatus.Stopped;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0004F434 File Offset: 0x0004D634
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0004F470 File Offset: 0x0004D670
		public float AutoSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float num;
				if (flag)
				{
					num = 0f;
				}
				else
				{
					num = DictationRecognizer.GetAutoSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return num;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetAutoSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0004F4E0 File Offset: 0x0004D6E0
		public float InitialSilenceTimeoutSeconds
		{
			get
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				float num;
				if (flag)
				{
					num = 0f;
				}
				else
				{
					num = DictationRecognizer.GetInitialSilenceTimeoutSeconds(this.m_Recognizer);
				}
				return num;
			}
			set
			{
				bool flag = this.m_Recognizer == IntPtr.Zero;
				if (!flag)
				{
					DictationRecognizer.SetInitialSilenceTimeoutSeconds(this.m_Recognizer, value);
				}
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0004F514 File Offset: 0x0004D714
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Recognizer != IntPtr.Zero;
				if (flag)
				{
					DictationRecognizer.DestroyThreaded(this.m_Recognizer);
					this.m_Recognizer = IntPtr.Zero;
					GC.SuppressFinalize(this);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0004F574 File Offset: 0x0004D774
		public void Start()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Start(this.m_Recognizer);
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0004F5A4 File Offset: 0x0004D7A4
		public void Stop()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				DictationRecognizer.Stop(this.m_Recognizer);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0004F5D4 File Offset: 0x0004D7D4
		public void Dispose()
		{
			bool flag = this.m_Recognizer != IntPtr.Zero;
			if (flag)
			{
				DictationRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_DictationHypothesis;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_DictationResult;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_DictationComplete;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr_DictationError;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly DictationRecognizer.CreateDelegate CreateDelegateField;

		// Token: 0x04000F58 RID: 3928
		private static readonly DictationRecognizer.StartDelegate StartDelegateField;

		// Token: 0x04000F59 RID: 3929
		private static readonly DictationRecognizer.StopDelegate StopDelegateField;

		// Token: 0x04000F5A RID: 3930
		private static readonly DictationRecognizer.DestroyDelegate DestroyDelegateField;

		// Token: 0x04000F5B RID: 3931
		private static readonly DictationRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;

		// Token: 0x04000F5C RID: 3932
		private static readonly DictationRecognizer.GetStatusDelegate GetStatusDelegateField;

		// Token: 0x04000F5D RID: 3933
		private static readonly DictationRecognizer.GetAutoSilenceTimeoutSecondsDelegate GetAutoSilenceTimeoutSecondsDelegateField;

		// Token: 0x04000F5E RID: 3934
		private static readonly DictationRecognizer.SetAutoSilenceTimeoutSecondsDelegate SetAutoSilenceTimeoutSecondsDelegateField;

		// Token: 0x04000F5F RID: 3935
		private static readonly DictationRecognizer.GetInitialSilenceTimeoutSecondsDelegate GetInitialSilenceTimeoutSecondsDelegateField;

		// Token: 0x04000F60 RID: 3936
		private static readonly DictationRecognizer.SetInitialSilenceTimeoutSecondsDelegate SetInitialSilenceTimeoutSecondsDelegateField;

		// Token: 0x02000895 RID: 2197
		public sealed class DictationHypothesisDelegate : MulticastDelegate
		{
			// Token: 0x06002EEB RID: 12011 RVA: 0x000156C5 File Offset: 0x000138C5
			// Note: this type is marked as 'beforefieldinit'.
			static DictationHypothesisDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesisDelegate");
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100664782);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100664783);
			}

			// Token: 0x06002EEC RID: 12012 RVA: 0x0006D048 File Offset: 0x0006B248
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationHypothesisDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x0006D0A4 File Offset: 0x0006B2A4
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EEE RID: 12014 RVA: 0x00015703 File Offset: 0x00013903
			public DictationHypothesisDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EEF RID: 12015 RVA: 0x0001570C File Offset: 0x0001390C
			public static implicit operator DictationRecognizer.DictationHypothesisDelegate(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationHypothesisDelegate>(A_0);
			}

			// Token: 0x06002EF0 RID: 12016 RVA: 0x00015714 File Offset: 0x00013914
			public static DictationRecognizer.DictationHypothesisDelegate operator +(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationHypothesisDelegate>();
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x00015722 File Offset: 0x00013922
			public static DictationRecognizer.DictationHypothesisDelegate operator -(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationHypothesisDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CCC RID: 7372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CCD RID: 7373
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;
		}

		// Token: 0x02000896 RID: 2198
		public sealed class DictationResultDelegate : MulticastDelegate
		{
			// Token: 0x06002EF2 RID: 12018 RVA: 0x00015733 File Offset: 0x00013933
			// Note: this type is marked as 'beforefieldinit'.
			static DictationResultDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResultDelegate");
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100664784);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100664785);
			}

			// Token: 0x06002EF3 RID: 12019 RVA: 0x0006D0E8 File Offset: 0x0006B2E8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationResultDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EF4 RID: 12020 RVA: 0x0006D144 File Offset: 0x0006B344
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79653, XrefRangeEnd = 79669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string text, ConfidenceLevel confidence)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EF5 RID: 12021 RVA: 0x00015771 File Offset: 0x00013971
			public DictationResultDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EF6 RID: 12022 RVA: 0x0001577A File Offset: 0x0001397A
			public static implicit operator DictationRecognizer.DictationResultDelegate(Action<string, ConfidenceLevel> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationResultDelegate>(A_0);
			}

			// Token: 0x06002EF7 RID: 12023 RVA: 0x00015782 File Offset: 0x00013982
			public static DictationRecognizer.DictationResultDelegate operator +(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationResultDelegate>();
			}

			// Token: 0x06002EF8 RID: 12024 RVA: 0x00015790 File Offset: 0x00013990
			public static DictationRecognizer.DictationResultDelegate operator -(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationResultDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CCE RID: 7374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CCF RID: 7375
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;
		}

		// Token: 0x02000897 RID: 2199
		public sealed class DictationCompletedDelegate : MulticastDelegate
		{
			// Token: 0x06002EF9 RID: 12025 RVA: 0x000157A1 File Offset: 0x000139A1
			// Note: this type is marked as 'beforefieldinit'.
			static DictationCompletedDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationCompletedDelegate");
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100664786);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100664787);
			}

			// Token: 0x06002EFA RID: 12026 RVA: 0x0006D194 File Offset: 0x0006B394
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationCompletedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EFB RID: 12027 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 79599, RefRangeEnd = 79617, XrefRangeStart = 79599, XrefRangeEnd = 79617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(DictationCompletionCause cause)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref cause;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EFC RID: 12028 RVA: 0x000157DF File Offset: 0x000139DF
			public DictationCompletedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EFD RID: 12029 RVA: 0x000157E8 File Offset: 0x000139E8
			public static implicit operator DictationRecognizer.DictationCompletedDelegate(Action<DictationCompletionCause> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationCompletedDelegate>(A_0);
			}

			// Token: 0x06002EFE RID: 12030 RVA: 0x000157F0 File Offset: 0x000139F0
			public static DictationRecognizer.DictationCompletedDelegate operator +(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationCompletedDelegate>();
			}

			// Token: 0x06002EFF RID: 12031 RVA: 0x000157FE File Offset: 0x000139FE
			public static DictationRecognizer.DictationCompletedDelegate operator -(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationCompletedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CD0 RID: 7376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CD1 RID: 7377
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;
		}

		// Token: 0x02000898 RID: 2200
		public sealed class DictationErrorHandler : MulticastDelegate
		{
			// Token: 0x06002F00 RID: 12032 RVA: 0x0001580F File Offset: 0x00013A0F
			// Note: this type is marked as 'beforefieldinit'.
			static DictationErrorHandler()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationErrorHandler");
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100664788);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100664789);
			}

			// Token: 0x06002F01 RID: 12033 RVA: 0x0006D230 File Offset: 0x0006B430
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationErrorHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F02 RID: 12034 RVA: 0x0006D28C File Offset: 0x0006B48C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string error, int hresult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F03 RID: 12035 RVA: 0x0001584D File Offset: 0x00013A4D
			public DictationErrorHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F04 RID: 12036 RVA: 0x00015856 File Offset: 0x00013A56
			public static implicit operator DictationRecognizer.DictationErrorHandler(Action<string, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationErrorHandler>(A_0);
			}

			// Token: 0x06002F05 RID: 12037 RVA: 0x0001585E File Offset: 0x00013A5E
			public static DictationRecognizer.DictationErrorHandler operator +(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationErrorHandler>();
			}

			// Token: 0x06002F06 RID: 12038 RVA: 0x0001586C File Offset: 0x00013A6C
			public static DictationRecognizer.DictationErrorHandler operator -(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DictationRecognizer.DictationErrorHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001CD2 RID: 7378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CD3 RID: 7379
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;
		}

		// Token: 0x02000899 RID: 2201
		// (Invoke) Token: 0x06002F08 RID: 12040
		private delegate IntPtr CreateDelegate(IntPtr self, ConfidenceLevel minimumConfidence, DictationTopicConstraint topicConstraint);

		// Token: 0x0200089A RID: 2202
		// (Invoke) Token: 0x06002F0A RID: 12042
		private delegate void StartDelegate(IntPtr self);

		// Token: 0x0200089B RID: 2203
		// (Invoke) Token: 0x06002F0C RID: 12044
		private delegate void StopDelegate(IntPtr self);

		// Token: 0x0200089C RID: 2204
		// (Invoke) Token: 0x06002F0E RID: 12046
		private delegate void DestroyDelegate(IntPtr self);

		// Token: 0x0200089D RID: 2205
		// (Invoke) Token: 0x06002F10 RID: 12048
		private delegate void DestroyThreadedDelegate(IntPtr self);

		// Token: 0x0200089E RID: 2206
		// (Invoke) Token: 0x06002F12 RID: 12050
		private delegate SpeechSystemStatus GetStatusDelegate(IntPtr self);

		// Token: 0x0200089F RID: 2207
		// (Invoke) Token: 0x06002F14 RID: 12052
		private delegate float GetAutoSilenceTimeoutSecondsDelegate(IntPtr self);

		// Token: 0x020008A0 RID: 2208
		// (Invoke) Token: 0x06002F16 RID: 12054
		private delegate void SetAutoSilenceTimeoutSecondsDelegate(IntPtr self, float value);

		// Token: 0x020008A1 RID: 2209
		// (Invoke) Token: 0x06002F18 RID: 12056
		private delegate float GetInitialSilenceTimeoutSecondsDelegate(IntPtr self);

		// Token: 0x020008A2 RID: 2210
		// (Invoke) Token: 0x06002F1A RID: 12058
		private delegate void SetInitialSilenceTimeoutSecondsDelegate(IntPtr self, float value);
	}
}
