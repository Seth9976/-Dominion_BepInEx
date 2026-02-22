using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x0200010E RID: 270
	public static class Console : Object
	{
		// Token: 0x060013E8 RID: 5096 RVA: 0x0007D518 File Offset: 0x0007B718
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Console");
			Console.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdout");
			Console.NativeFieldInfoPtr_stderr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stderr");
			Console.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdin");
			Console.NativeFieldInfoPtr_inputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "inputEncoding");
			Console.NativeFieldInfoPtr_outputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "outputEncoding");
			Console.NativeFieldInfoPtr_cancel_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_event");
			Console.NativeFieldInfoPtr_cancel_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_handler");
			Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666709);
			Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666710);
			Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666711);
			Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666712);
			Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666713);
			Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666714);
			Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666715);
			Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666716);
			Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666717);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666718);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666719);
			Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100666720);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0007D6BC File Offset: 0x0007B8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304701, RefRangeEnd = 304702, XrefRangeStart = 304597, XrefRangeEnd = 304701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputEncoding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputEncoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0007D704 File Offset: 0x0007B904
		public unsafe static TextWriter Error
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304702, XrefRangeEnd = 304706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0007D738 File Offset: 0x0007B938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304716, RefRangeEnd = 304719, XrefRangeStart = 304706, XrefRangeEnd = 304716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0007D794 File Offset: 0x0007B994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304727, RefRangeEnd = 304729, XrefRangeStart = 304719, XrefRangeEnd = 304727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardError(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0007D7D4 File Offset: 0x0007B9D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304737, RefRangeEnd = 304740, XrefRangeStart = 304729, XrefRangeEnd = 304737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardInput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0007D814 File Offset: 0x0007BA14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304748, RefRangeEnd = 304750, XrefRangeStart = 304740, XrefRangeEnd = 304748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardOutput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0007D854 File Offset: 0x0007BA54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304754, RefRangeEnd = 304755, XrefRangeStart = 304750, XrefRangeEnd = 304754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOut(TextWriter newOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0007D88C File Offset: 0x0007BA8C
		public unsafe static Encoding InputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304755, XrefRangeEnd = 304759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0007D8C0 File Offset: 0x0007BAC0
		public unsafe static Encoding OutputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304759, XrefRangeEnd = 304763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0007D8F4 File Offset: 0x0007BAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304777, RefRangeEnd = 304778, XrefRangeStart = 304763, XrefRangeEnd = 304777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0007D924 File Offset: 0x0007BB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304778, XrefRangeEnd = 304789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0007D964 File Offset: 0x0007BB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304809, RefRangeEnd = 304810, XrefRangeStart = 304789, XrefRangeEnd = 304809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoConsoleCancelEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00006F66 File Offset: 0x00005166
		public Console(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0007D98C File Offset: 0x0007BB8C
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00006F6F File Offset: 0x0000516F
		public unsafe static TextWriter stdout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdout, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdout, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0007D9B4 File Offset: 0x0007BBB4
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00006F81 File Offset: 0x00005181
		public unsafe static TextWriter stderr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stderr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stderr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0007D9DC File Offset: 0x0007BBDC
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00006F93 File Offset: 0x00005193
		public unsafe static TextReader stdin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0007DA04 File Offset: 0x0007BC04
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x00006FA5 File Offset: 0x000051A5
		public unsafe static Encoding inputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_inputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_inputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0007DA2C File Offset: 0x0007BC2C
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00006FB7 File Offset: 0x000051B7
		public unsafe static Encoding outputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_outputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_outputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0007DA54 File Offset: 0x0007BC54
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00006FC9 File Offset: 0x000051C9
		public unsafe static ConsoleCancelEventHandler cancel_event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_cancel_event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsoleCancelEventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_cancel_event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0007DA7C File Offset: 0x0007BC7C
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00006FDB File Offset: 0x000051DB
		public unsafe static Console.InternalCancelHandler cancel_handler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_cancel_handler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Console.InternalCancelHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_cancel_handler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_stderr;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr_inputEncoding;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr_outputEncoding;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_cancel_event;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr_cancel_handler;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_DoConsoleCancelEvent_Internal_Static_Void_0;

		// Token: 0x020005A8 RID: 1448
		public class WindowsConsole : Object
		{
			// Token: 0x06004F9F RID: 20383 RVA: 0x00165DE4 File Offset: 0x00163FE4
			// Note: this type is marked as 'beforefieldinit'.
			static WindowsConsole()
			{
				Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "WindowsConsole");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr);
				Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "ctrlHandlerAdded");
				Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "cancelHandler");
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666721);
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666722);
				Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666723);
				Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666724);
				Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100666725);
			}

			// Token: 0x06004FA0 RID: 20384 RVA: 0x00165E9C File Offset: 0x0016409C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304577, XrefRangeEnd = 304579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FA1 RID: 20385 RVA: 0x00165ECC File Offset: 0x001640CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304579, XrefRangeEnd = 304581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleOutputCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FA2 RID: 20386 RVA: 0x00165EFC File Offset: 0x001640FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304581, XrefRangeEnd = 304585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref keyCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FA3 RID: 20387 RVA: 0x00165F3C File Offset: 0x0016413C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 304590, RefRangeEnd = 304591, XrefRangeStart = 304585, XrefRangeEnd = 304590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetInputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FA4 RID: 20388 RVA: 0x00165F6C File Offset: 0x0016416C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 304596, RefRangeEnd = 304597, XrefRangeStart = 304591, XrefRangeEnd = 304596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetOutputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x0001E340 File Offset: 0x0001C540
			public WindowsConsole(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001444 RID: 5188
			// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x00165F9C File Offset: 0x0016419C
			// (set) Token: 0x06004FA7 RID: 20391 RVA: 0x0001E349 File Offset: 0x0001C549
			public unsafe static bool ctrlHandlerAdded
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&value));
				}
			}

			// Token: 0x17001445 RID: 5189
			// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x00165FB8 File Offset: 0x001641B8
			// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x0001E357 File Offset: 0x0001C557
			public unsafe static Console.WindowsConsole.WindowsCancelHandler cancelHandler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Console.WindowsConsole.WindowsCancelHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040DC RID: 16604
			private static readonly IntPtr NativeFieldInfoPtr_ctrlHandlerAdded;

			// Token: 0x040040DD RID: 16605
			private static readonly IntPtr NativeFieldInfoPtr_cancelHandler;

			// Token: 0x040040DE RID: 16606
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0;

			// Token: 0x040040DF RID: 16607
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0;

			// Token: 0x040040E0 RID: 16608
			private static readonly IntPtr NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0;

			// Token: 0x040040E1 RID: 16609
			private static readonly IntPtr NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0;

			// Token: 0x040040E2 RID: 16610
			private static readonly IntPtr NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0;

			// Token: 0x020006C4 RID: 1732
			public sealed class WindowsCancelHandler : MulticastDelegate
			{
				// Token: 0x060057D1 RID: 22481 RVA: 0x00022684 File Offset: 0x00020884
				// Note: this type is marked as 'beforefieldinit'.
				static WindowsCancelHandler()
				{
					Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "WindowsCancelHandler");
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666727);
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100666728);
				}

				// Token: 0x060057D2 RID: 22482 RVA: 0x00180610 File Offset: 0x0017E810
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WindowsCancelHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057D3 RID: 22483 RVA: 0x0018066C File Offset: 0x0017E86C
				[CallerCount(0)]
				public unsafe bool Invoke(int keyCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref keyCode;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060057D4 RID: 22484 RVA: 0x000226C2 File Offset: 0x000208C2
				public WindowsCancelHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060057D5 RID: 22485 RVA: 0x000226CB File Offset: 0x000208CB
				public static implicit operator Console.WindowsConsole.WindowsCancelHandler(Func<int, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<Console.WindowsConsole.WindowsCancelHandler>(A_0);
				}

				// Token: 0x060057D6 RID: 22486 RVA: 0x000226D3 File Offset: 0x000208D3
				public static Console.WindowsConsole.WindowsCancelHandler operator +(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Console.WindowsConsole.WindowsCancelHandler>();
				}

				// Token: 0x060057D7 RID: 22487 RVA: 0x000226E1 File Offset: 0x000208E1
				public static Console.WindowsConsole.WindowsCancelHandler operator -(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Console.WindowsConsole.WindowsCancelHandler>();
					}
					return delegate2;
				}

				// Token: 0x0400461D RID: 17949
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400461E RID: 17950
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0;
			}
		}

		// Token: 0x020005A9 RID: 1449
		public sealed class InternalCancelHandler : MulticastDelegate
		{
			// Token: 0x06004FAA RID: 20394 RVA: 0x0001E369 File Offset: 0x0001C569
			// Note: this type is marked as 'beforefieldinit'.
			static InternalCancelHandler()
			{
				Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "InternalCancelHandler");
				Console.InternalCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666729);
				Console.InternalCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr, 100666730);
			}

			// Token: 0x06004FAB RID: 20395 RVA: 0x00165FE0 File Offset: 0x001641E0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalCancelHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.InternalCancelHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FAC RID: 20396 RVA: 0x0016603C File Offset: 0x0016423C
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.InternalCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FAD RID: 20397 RVA: 0x0001E3A7 File Offset: 0x0001C5A7
			public InternalCancelHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004FAE RID: 20398 RVA: 0x0001E3B0 File Offset: 0x0001C5B0
			public static implicit operator Console.InternalCancelHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Console.InternalCancelHandler>(A_0);
			}

			// Token: 0x06004FAF RID: 20399 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
			public static Console.InternalCancelHandler operator +(Console.InternalCancelHandler A_0, Console.InternalCancelHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Console.InternalCancelHandler>();
			}

			// Token: 0x06004FB0 RID: 20400 RVA: 0x0001E3C6 File Offset: 0x0001C5C6
			public static Console.InternalCancelHandler operator -(Console.InternalCancelHandler A_0, Console.InternalCancelHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Console.InternalCancelHandler>();
				}
				return delegate2;
			}

			// Token: 0x040040E3 RID: 16611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040040E4 RID: 16612
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
