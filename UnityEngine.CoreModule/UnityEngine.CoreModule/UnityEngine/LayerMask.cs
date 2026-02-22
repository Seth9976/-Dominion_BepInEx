using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B5 RID: 181
	[StructLayout(2)]
	public struct LayerMask
	{
		// Token: 0x060010AB RID: 4267 RVA: 0x00044004 File Offset: 0x00042204
		// Note: this type is marked as 'beforefieldinit'.
		static LayerMask()
		{
			Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LayerMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
			LayerMask.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, "m_Mask");
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664407);
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664408);
			LayerMask.LayerToNameDelegateField = IL2CPP.ResolveICall<LayerMask.LayerToNameDelegate>("UnityEngine.LayerMask::LayerToName");
			LayerMask.NameToLayerDelegateField = IL2CPP.ResolveICall<LayerMask.NameToLayerDelegate>("UnityEngine.LayerMask::NameToLayer");
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00044090 File Offset: 0x00042290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 72005, RefRangeEnd = 72012, XrefRangeStart = 72005, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(LayerMask mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000440D0 File Offset: 0x000422D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 72005, RefRangeEnd = 72012, XrefRangeStart = 72005, XrefRangeEnd = 72012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LayerMask(int intVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0000A3E8 File Offset: 0x000085E8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, ref this));
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00044110 File Offset: 0x00042310
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000A3FA File Offset: 0x000085FA
		public int value
		{
			get
			{
				return this.m_Mask;
			}
			set
			{
				this.m_Mask = value;
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00044128 File Offset: 0x00042328
		public static string LayerToName(int layer)
		{
			IntPtr intPtr = LayerMask.LayerToNameDelegateField(layer);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0000A404 File Offset: 0x00008604
		public static int NameToLayer(string layerName)
		{
			return LayerMask.NameToLayerDelegateField(IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000A416 File Offset: 0x00008616
		public static int GetMask(Il2CppStringArray layerNames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000A423 File Offset: 0x00008623
		public static int GetMask(params string[] layerNames)
		{
			return LayerMask.GetMask(new Il2CppStringArray(layerNames));
		}

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;

		// Token: 0x04000C8E RID: 3214
		[FieldOffset(0)]
		public int m_Mask;

		// Token: 0x04000C8F RID: 3215
		private static readonly LayerMask.LayerToNameDelegate LayerToNameDelegateField;

		// Token: 0x04000C90 RID: 3216
		private static readonly LayerMask.NameToLayerDelegate NameToLayerDelegateField;

		// Token: 0x0200079E RID: 1950
		// (Invoke) Token: 0x06002CE0 RID: 11488
		private delegate IntPtr LayerToNameDelegate(int layer);

		// Token: 0x0200079F RID: 1951
		// (Invoke) Token: 0x06002CE2 RID: 11490
		private delegate int NameToLayerDelegate(IntPtr layerName);
	}
}
