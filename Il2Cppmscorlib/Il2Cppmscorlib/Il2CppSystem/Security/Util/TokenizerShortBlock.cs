using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002C9 RID: 713
	public sealed class TokenizerShortBlock : Object
	{
		// Token: 0x06002F82 RID: 12162 RVA: 0x000EEC04 File Offset: 0x000ECE04
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerShortBlock()
		{
			Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerShortBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr);
			TokenizerShortBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_block");
			TokenizerShortBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_next");
			TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, 100670816);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000EEC70 File Offset: 0x000ECE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338063, XrefRangeEnd = 338067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerShortBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00010A8B File Offset: 0x0000EC8B
		public TokenizerShortBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x000EECAC File Offset: 0x000ECEAC
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00010A94 File Offset: 0x0000EC94
		public unsafe Il2CppStructArray<short> m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000EECDC File Offset: 0x000ECEDC
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00010AB3 File Offset: 0x0000ECB3
		public unsafe TokenizerShortBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
