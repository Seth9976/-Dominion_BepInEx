using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000EC RID: 236
	public class PhraseRecognizer : Object
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x0004ED10 File Offset: 0x0004CF10
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizer()
		{
			Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr);
			PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "m_Recognizer");
			PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "OnPhraseRecognized");
			PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100664774);
			PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100664775);
			PhraseRecognizer.CreateFromKeywordsDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromKeywordsDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromKeywords");
			PhraseRecognizer.CreateFromGrammarFileDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.CreateFromGrammarFileDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::CreateFromGrammarFile");
			PhraseRecognizer.Start_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Start_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Start_Internal");
			PhraseRecognizer.Stop_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.Stop_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Stop_Internal");
			PhraseRecognizer.IsRunning_InternalDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.IsRunning_InternalDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::IsRunning_Internal");
			PhraseRecognizer.DestroyDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::Destroy");
			PhraseRecognizer.DestroyThreadedDelegateField = IL2CPP.ResolveICall<PhraseRecognizer.DestroyThreadedDelegate>("UnityEngine.Windows.Speech.PhraseRecognizer::DestroyThreaded");
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0004EDFC File Offset: 0x0004CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79631, XrefRangeEnd = 79640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartFileTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDurationTicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0004EE7C File Offset: 0x0004D07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79640, XrefRangeEnd = 79653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<SemanticMeaning> MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref values;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueSizes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr3) : null;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0000BD01 File Offset: 0x00009F01
		public PhraseRecognizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0004EEE8 File Offset: 0x0004D0E8
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x0000BD0A File Offset: 0x00009F0A
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0004EF10 File Offset: 0x0004D110
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0000BD25 File Offset: 0x00009F25
		public unsafe PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognizer.PhraseRecognizedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0000BD44 File Offset: 0x00009F44
		public static IntPtr CreateFromKeywords(Object self, Il2CppStringArray keywords, ConfidenceLevel minimumConfidence)
		{
			return PhraseRecognizer.CreateFromKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(keywords), minimumConfidence);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0000BD5D File Offset: 0x00009F5D
		public static IntPtr CreateFromGrammarFile(Object self, string grammarFilePath, ConfidenceLevel minimumConfidence)
		{
			return PhraseRecognizer.CreateFromGrammarFileDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(grammarFilePath), minimumConfidence);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0000BD76 File Offset: 0x00009F76
		public static void Start_Internal(IntPtr recognizer)
		{
			PhraseRecognizer.Start_InternalDelegateField(recognizer);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0000BD83 File Offset: 0x00009F83
		public static void Stop_Internal(IntPtr recognizer)
		{
			PhraseRecognizer.Stop_InternalDelegateField(recognizer);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0000BD90 File Offset: 0x00009F90
		public static bool IsRunning_Internal(IntPtr recognizer)
		{
			return PhraseRecognizer.IsRunning_InternalDelegateField(recognizer);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0000BD9D File Offset: 0x00009F9D
		public static void Destroy(IntPtr recognizer)
		{
			PhraseRecognizer.DestroyDelegateField(recognizer);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000BDAA File Offset: 0x00009FAA
		public static void DestroyThreaded(IntPtr recognizer)
		{
			PhraseRecognizer.DestroyThreadedDelegateField(recognizer);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0000BDB7 File Offset: 0x00009FB7
		public void add_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		public void remove_OnPhraseRecognized(PhraseRecognizer.PhraseRecognizedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0004EF40 File Offset: 0x0004D140
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Recognizer != IntPtr.Zero;
				if (flag)
				{
					PhraseRecognizer.DestroyThreaded(this.m_Recognizer);
					this.m_Recognizer = IntPtr.Zero;
					GC.SuppressFinalize(this);
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0004EFA0 File Offset: 0x0004D1A0
		public void Start()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				PhraseRecognizer.Start_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0004EFD0 File Offset: 0x0004D1D0
		public void Stop()
		{
			bool flag = this.m_Recognizer == IntPtr.Zero;
			if (!flag)
			{
				PhraseRecognizer.Stop_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0004F000 File Offset: 0x0004D200
		public void Dispose()
		{
			bool flag = this.m_Recognizer != IntPtr.Zero;
			if (flag)
			{
				PhraseRecognizer.Destroy(this.m_Recognizer);
				this.m_Recognizer = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0004F044 File Offset: 0x0004D244
		public bool IsRunning
		{
			get
			{
				return this.m_Recognizer != IntPtr.Zero && PhraseRecognizer.IsRunning_Internal(this.m_Recognizer);
			}
		}

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_OnPhraseRecognized;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly PhraseRecognizer.CreateFromKeywordsDelegate CreateFromKeywordsDelegateField;

		// Token: 0x04000F48 RID: 3912
		private static readonly PhraseRecognizer.CreateFromGrammarFileDelegate CreateFromGrammarFileDelegateField;

		// Token: 0x04000F49 RID: 3913
		private static readonly PhraseRecognizer.Start_InternalDelegate Start_InternalDelegateField;

		// Token: 0x04000F4A RID: 3914
		private static readonly PhraseRecognizer.Stop_InternalDelegate Stop_InternalDelegateField;

		// Token: 0x04000F4B RID: 3915
		private static readonly PhraseRecognizer.IsRunning_InternalDelegate IsRunning_InternalDelegateField;

		// Token: 0x04000F4C RID: 3916
		private static readonly PhraseRecognizer.DestroyDelegate DestroyDelegateField;

		// Token: 0x04000F4D RID: 3917
		private static readonly PhraseRecognizer.DestroyThreadedDelegate DestroyThreadedDelegateField;

		// Token: 0x0200088D RID: 2189
		public sealed class PhraseRecognizedDelegate : MulticastDelegate
		{
			// Token: 0x06002ED6 RID: 11990 RVA: 0x00015657 File Offset: 0x00013857
			// Note: this type is marked as 'beforefieldinit'.
			static PhraseRecognizedDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "PhraseRecognizedDelegate");
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100664776);
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100664777);
			}

			// Token: 0x06002ED7 RID: 11991 RVA: 0x0006CFA4 File Offset: 0x0006B1A4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PhraseRecognizedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ED8 RID: 11992 RVA: 0x0006D000 File Offset: 0x0006B200
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79629, RefRangeEnd = 79631, XrefRangeStart = 79623, XrefRangeEnd = 79629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(PhraseRecognizedEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ED9 RID: 11993 RVA: 0x00015695 File Offset: 0x00013895
			public PhraseRecognizedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EDA RID: 11994 RVA: 0x0001569E File Offset: 0x0001389E
			public static implicit operator PhraseRecognizer.PhraseRecognizedDelegate(Action<PhraseRecognizedEventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognizer.PhraseRecognizedDelegate>(A_0);
			}

			// Token: 0x06002EDB RID: 11995 RVA: 0x000156A6 File Offset: 0x000138A6
			public static PhraseRecognizer.PhraseRecognizedDelegate operator +(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
			}

			// Token: 0x06002EDC RID: 11996 RVA: 0x000156B4 File Offset: 0x000138B4
			public static PhraseRecognizer.PhraseRecognizedDelegate operator -(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CCA RID: 7370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CCB RID: 7371
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0;
		}

		// Token: 0x0200088E RID: 2190
		// (Invoke) Token: 0x06002EDE RID: 11998
		private delegate IntPtr CreateFromKeywordsDelegate(IntPtr self, IntPtr keywords, ConfidenceLevel minimumConfidence);

		// Token: 0x0200088F RID: 2191
		// (Invoke) Token: 0x06002EE0 RID: 12000
		private delegate IntPtr CreateFromGrammarFileDelegate(IntPtr self, IntPtr grammarFilePath, ConfidenceLevel minimumConfidence);

		// Token: 0x02000890 RID: 2192
		// (Invoke) Token: 0x06002EE2 RID: 12002
		private delegate void Start_InternalDelegate(IntPtr recognizer);

		// Token: 0x02000891 RID: 2193
		// (Invoke) Token: 0x06002EE4 RID: 12004
		private delegate void Stop_InternalDelegate(IntPtr recognizer);

		// Token: 0x02000892 RID: 2194
		// (Invoke) Token: 0x06002EE6 RID: 12006
		private delegate bool IsRunning_InternalDelegate(IntPtr recognizer);

		// Token: 0x02000893 RID: 2195
		// (Invoke) Token: 0x06002EE8 RID: 12008
		private delegate void DestroyDelegate(IntPtr recognizer);

		// Token: 0x02000894 RID: 2196
		// (Invoke) Token: 0x06002EEA RID: 12010
		private delegate void DestroyThreadedDelegate(IntPtr recognizer);
	}
}
