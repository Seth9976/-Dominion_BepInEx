using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000165 RID: 357
	[StructLayout(2)]
	public struct CameraPlayable
	{
		// Token: 0x06001AB8 RID: 6840 RVA: 0x0005F7A0 File Offset: 0x0005D9A0
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPlayable()
		{
			Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "CameraPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
			CameraPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, "m_Handle");
			CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100665266);
			CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100665267);
			CameraPlayable.GetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.GetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal");
			CameraPlayable.SetCameraInternalDelegateField = IL2CPP.ResolveICall<CameraPlayable.SetCameraInternalDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal");
			CameraPlayable.InternalCreateCameraPlayableDelegateField = IL2CPP.ResolveICall<CameraPlayable.InternalCreateCameraPlayableDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable");
			CameraPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<CameraPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0005F848 File Offset: 0x0005DA48
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0005F878 File Offset: 0x0005DA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83127, XrefRangeEnd = 83135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0000EC14 File Offset: 0x0000CE14
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0005F8B8 File Offset: 0x0005DAB8
		public static CameraPlayable Create(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = CameraPlayable.CreateHandle(graph, camera);
			return new CameraPlayable(playableHandle);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0005F8D8 File Offset: 0x0005DAD8
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Camera camera)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !CameraPlayable.InternalCreateCameraPlayable(ref graph, camera, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0005F90C File Offset: 0x0005DB0C
		public static implicit operator UnityEngine.Playables.Playable(CameraPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0005F92C File Offset: 0x0005DB2C
		public static explicit operator CameraPlayable(UnityEngine.Playables.Playable playable)
		{
			return new CameraPlayable(playable.GetHandle());
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0005F94C File Offset: 0x0005DB4C
		public Camera GetCamera()
		{
			return CameraPlayable.GetCameraInternal(ref this.m_Handle);
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0000EC26 File Offset: 0x0000CE26
		public void SetCamera(Camera value)
		{
			CameraPlayable.SetCameraInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0005F96C File Offset: 0x0005DB6C
		public static Camera GetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = CameraPlayable.GetCameraInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0000EC36 File Offset: 0x0000CE36
		public static void SetCameraInternal(ref UnityEngine.Playables.PlayableHandle hdl, Camera camera)
		{
			CameraPlayable.SetCameraInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0000EC49 File Offset: 0x0000CE49
		public static bool InternalCreateCameraPlayable(ref UnityEngine.Playables.PlayableGraph graph, Camera camera, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return CameraPlayable.InternalCreateCameraPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(camera), ref handle);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0000EC5D File Offset: 0x0000CE5D
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return CameraPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;

		// Token: 0x04001420 RID: 5152
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04001421 RID: 5153
		private static readonly CameraPlayable.GetCameraInternalDelegate GetCameraInternalDelegateField;

		// Token: 0x04001422 RID: 5154
		private static readonly CameraPlayable.SetCameraInternalDelegate SetCameraInternalDelegateField;

		// Token: 0x04001423 RID: 5155
		private static readonly CameraPlayable.InternalCreateCameraPlayableDelegate InternalCreateCameraPlayableDelegateField;

		// Token: 0x04001424 RID: 5156
		private static readonly CameraPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A08 RID: 2568
		// (Invoke) Token: 0x06003236 RID: 12854
		private delegate IntPtr GetCameraInternalDelegate(IntPtr hdl);

		// Token: 0x02000A09 RID: 2569
		// (Invoke) Token: 0x06003238 RID: 12856
		private delegate void SetCameraInternalDelegate(IntPtr hdl, IntPtr camera);

		// Token: 0x02000A0A RID: 2570
		// (Invoke) Token: 0x0600323A RID: 12858
		private delegate bool InternalCreateCameraPlayableDelegate(IntPtr graph, IntPtr camera, IntPtr handle);

		// Token: 0x02000A0B RID: 2571
		// (Invoke) Token: 0x0600323C RID: 12860
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
