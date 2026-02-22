using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002D1 RID: 721
	public class WindowsImpersonationContext : Object
	{
		// Token: 0x06002FCF RID: 12239 RVA: 0x000EFAA8 File Offset: 0x000EDCA8
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsImpersonationContext()
		{
			Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsImpersonationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr);
			WindowsImpersonationContext.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "_token");
			WindowsImpersonationContext.NativeFieldInfoPtr_undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "undo");
			WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670845);
			WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670846);
			WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670847);
			WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670848);
			WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670849);
			WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670850);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000EFB78 File Offset: 0x000EDD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338263, XrefRangeEnd = 338269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000EFBAC File Offset: 0x000EDDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338269, XrefRangeEnd = 338286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000EFBE0 File Offset: 0x000EDDE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338287, RefRangeEnd = 338288, XrefRangeStart = 338286, XrefRangeEnd = 338287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000EFC20 File Offset: 0x000EDE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338288, XrefRangeEnd = 338289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr DuplicateToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x000EFC60 File Offset: 0x000EDE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338289, XrefRangeEnd = 338290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCurrentToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x000EFCA0 File Offset: 0x000EDEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338290, XrefRangeEnd = 338291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RevertToSelf()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00010D00 File Offset: 0x0000EF00
		public WindowsImpersonationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x000EFCD0 File Offset: 0x000EDED0
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00010D09 File Offset: 0x0000EF09
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x000EFCF8 File Offset: 0x000EDEF8
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x00010D24 File Offset: 0x0000EF24
		public unsafe bool undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo)) = value;
			}
		}

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeFieldInfoPtr_undo;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0;
	}
}
