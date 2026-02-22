using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002C7 RID: 711
	public sealed class Parser : Object
	{
		// Token: 0x06002F4E RID: 12110 RVA: 0x000EE300 File Offset: 0x000EC500
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr__doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_doc");
			Parser.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_t");
			Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670795);
			Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670796);
			Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670797);
			Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670798);
			Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670799);
			Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100670800);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000EE3D0 File Offset: 0x000EC5D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337872, RefRangeEnd = 337874, XrefRangeStart = 337870, XrefRangeEnd = 337872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetTopElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000EE410 File Offset: 0x000EC610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337925, RefRangeEnd = 337926, XrefRangeStart = 337874, XrefRangeEnd = 337925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000EE460 File Offset: 0x000EC660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337943, RefRangeEnd = 337944, XrefRangeStart = 337926, XrefRangeEnd = 337943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DetermineFormat(TokenizerStream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000EE4B0 File Offset: 0x000EC6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337980, RefRangeEnd = 337981, XrefRangeStart = 337944, XrefRangeEnd = 337980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000EE4E4 File Offset: 0x000EC6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337985, RefRangeEnd = 337986, XrefRangeStart = 337981, XrefRangeEnd = 337985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(Tokenizer t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000EE530 File Offset: 0x000EC730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337991, RefRangeEnd = 337993, XrefRangeStart = 337986, XrefRangeEnd = 337991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x0001086B File Offset: 0x0000EA6B
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000EE57C File Offset: 0x000EC77C
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00010874 File Offset: 0x0000EA74
		public unsafe SecurityDocument _doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000EE5AC File Offset: 0x000EC7AC
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x00010893 File Offset: 0x0000EA93
		public unsafe Tokenizer _t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeFieldInfoPtr__doc;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeFieldInfoPtr__t;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_ParseContents_Private_Void_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
	}
}
