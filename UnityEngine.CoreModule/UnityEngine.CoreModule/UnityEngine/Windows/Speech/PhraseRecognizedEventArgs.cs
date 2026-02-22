using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000F3 RID: 243
	public sealed class PhraseRecognizedEventArgs : ValueType
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizedEventArgs()
		{
			Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "confidence");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "semanticMeanings");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "text");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseStartTime");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseDuration");
			PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100664790);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0004F770 File Offset: 0x0004D970
		[CallerCount(0)]
		public unsafe PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000BFBD File Offset: 0x0000A1BD
		public PhraseRecognizedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0000BFC6 File Offset: 0x0000A1C6
		public PhraseRecognizedEventArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0004F7FC File Offset: 0x0004D9FC
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public unsafe ConfidenceLevel confidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0004F824 File Offset: 0x0004DA24
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x0000BFF3 File Offset: 0x0000A1F3
		public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0004F854 File Offset: 0x0004DA54
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x0000C012 File Offset: 0x0000A212
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0004F87C File Offset: 0x0004DA7C
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0000C031 File Offset: 0x0000A231
		public unsafe DateTime phraseStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0004F8A4 File Offset: 0x0004DAA4
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x0000C04C File Offset: 0x0000A24C
		public unsafe TimeSpan phraseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration)) = value;
			}
		}

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeFieldInfoPtr_confidence;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeFieldInfoPtr_semanticMeanings;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeFieldInfoPtr_phraseStartTime;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeFieldInfoPtr_phraseDuration;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;
	}
}
